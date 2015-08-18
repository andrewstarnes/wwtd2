using UnityEngine;
using System.Collections;

public class ST_FireTurretControl : MonoBehaviour {
	
	public enum ControlType { AI_AutoTarget, AI_NoTarget, Player }
	
	[Header("Turret will get this target:")]
	[Tooltip("If using AI_Auto Target, the targeting script will provide this target.")]
	public GameObject target;
	[Tooltip("AI_Auto Target: AI will use a scanner to pick targets.\n" +
	         "AI_NoTarget: AI will not pick targets, but will aim and fire if it is given a target.\n" +
	         "Player: Turret will be under player control.")]
	public ControlType controller;
	[Tooltip("Player to control this turret if Controller is set to player.")]
	public GameObject player;
	[Header("Weapon list:")]
	public WeaponData[] weapons;
	[Header("Multiple weapons on a single turret:")]
	[Tooltip("(meters)\n0 = don't angle weapons")]
	public float fixedConvergeRange; // 0 = don't converge
	[Tooltip("Will angle weapons slightly to converge fire baed on target range.")]
	public bool dynamicConverge;
	[Tooltip("(deg/sec)\nWhen using Dynamic Converge.")]
	public float convergeSlewRate = 2f;
	[Tooltip("(meters)\nWhen using Dynamic Converge, limits how far weapons will angle inwards")]
	public float minConvergeRange;
	[Tooltip("For multiple weapons per turret.\nWill alternate their fire instead of firing all at once.")]
	public bool alternatingFire;
	[Header("Options:")]
	[Tooltip("Uses Raycast to check line of sight before firing.")]
	public bool checkLOS;
	[Tooltip("Increase time between Raycast LOS checks to improve performance.")]
	public float losCheckInterval; 
	[Tooltip("Will limit inaccuracy imparted to weapons due to any turning/acceleration. If this is less than a weapon's inaccuracy, it will have no effect.")]
	public float maxInaccuracy;
	[Tooltip("Try to determine target size from collider.")]
	public bool checkTargetSize;
	[Tooltip("(meters)\nDefault target size to fire at if none found or provided.")]
	public float targetSizeDefault;
	
	[HideInInspector] public int curWeapon;
	
	MF_AbstractTargeting targetingScript;
	ST_FireTurret turretScript;
	ST_Player playerScript;
	float targetSize = 10f;
	float lastLosCheck;
	float lastFire;
	float oldTurnWeapInaccuracy;
	GameObject playerToggle;
	GameObject storedTarget;
	bool error;
	
	[System.Serializable]
	public class WeaponData {
		public GameObject weapon;
		[HideInInspector] public MF_FireWeapon script;
	}
	
	void Start () {
		if (CheckErrors() == true) { return; }
		
		turretScript = GetComponent<ST_FireTurret>();
		if ( GetComponent<MF_AbstractTargeting>() ) {
			targetingScript = GetComponent<MF_AbstractTargeting>();
		}
		
		if(this.targetSizeDefault==0) {
			this.targetSizeDefault = 10f;
		}
		// cache scripts for all weapons
		if ( weapons.Length > 0 ) {
			for (int wd=0; wd < weapons.Length; wd++) {
				if (weapons[wd].weapon) {
					weapons[wd].script = weapons[wd].weapon.GetComponent<MF_FireWeapon>();
				}
			}
			//set fixed converge angle of weapons relative to weaponMount forward direction, to converge at given range. 0 = no fixed convergence
			if (fixedConvergeRange > 0) {
				for (int w=0; w < weapons.Length; w++) {
					if (weapons[w].weapon) {
						weapons[w].weapon.transform.rotation = Quaternion.LookRotation( turretScript.weaponMount.transform.position +
						                                                               ( turretScript.weaponMount.transform.forward * fixedConvergeRange ) -
						                                                               weapons[w].weapon.transform.position, turretScript.weaponMount.transform.up );
					}
				}
			}
		}
	}
	
	void Update () {
		if (error == true) { return; }
		
		// player or AI control
		switch (controller) {
		case ControlType.Player :  // player will move aim object and hold mouse to fire
			if ( player ) { // make sure player is defined
				// detect change in player
				if ( player != playerToggle ) {
					playerToggle = player;
					playerScript = player.GetComponent<ST_Player>();
					target = playerScript.aimObject;
				}
				
				if ( playerScript.turretControl == true ) {
					target = playerScript.aimObject;
					if ( weapons.Length > 0 ) {
						if ( Input.GetMouseButton(0) ) {
							Shoot();
						}
					}
				}
			} else { // no player defined
				target = null;
			}
			break;
			
		case ControlType.AI_AutoTarget : // AI will aim, getting targets from targeting script
			if ( targetingScript ) { // make sure targeting script exsists
				target = targetingScript.weaponTarget;
				if(target == null) {
					for (int sw=0; sw < weapons.Length; sw++) {
						weapons[sw].script.DontShoot(); // includes ReadyCheck just in case weapons are different or out of sync
					}
				} else {
					
				}
			} else {
				target = null;
			}
			break;
			
		case ControlType.AI_NoTarget : // AI will aim, but targets must be supplied some other way
			break;
			
		default :
			break;
		}
		
		// if this is a new target, cache info
		if (target != storedTarget) {
			storedTarget = target;
			if (target) { // in case target became null
				if (checkTargetSize == true) {
					Bounds _bounds; 
					targetSize = 0f;
					if (target.GetComponent<Collider>()) { // does root have a collider?
						_bounds = target.GetComponent<Collider>().bounds;
						targetSize = Mathf.Max( _bounds.size.x * target.transform.localScale.x, _bounds.size.y * target.transform.localScale.y, _bounds.size.z * transform.localScale.z );
					} else { // no colldier found on target root
						// check root object's children for the first collider found
						for (int c=0; c < target.transform.childCount; c++) {
							if (target.transform.GetChild(c).GetComponent<Collider>()) { // found a collider
								_bounds = target.transform.GetChild(c).GetComponent<Collider>().bounds;
								targetSize = Mathf.Max( _bounds.size.x * target.transform.localScale.x, _bounds.size.y * target.transform.localScale.y, _bounds.size.z * transform.localScale.z );
								break; // don't need to keep checking
							}
						}
						// _bounds still 0, so no colliders found, use default
						if (targetSize == 0) { targetSize = targetSizeDefault; }
					}
				} else {
					// not checking size, use default
					targetSize = targetSizeDefault;
				}
			}
		}
		
		turretScript.target = target; // pass target to turret
		
		if (target) {
			if ( controller == ControlType.AI_AutoTarget || controller == ControlType.AI_NoTarget ) { // AI will shoot
				if ( weapons.Length > 0 ) {
					// set shot speed for turret aim intercept
					if ( turretScript.AimCheck( targetSize, weapons[curWeapon].script.aimTolerance ) == true ) { // check if turret is aimed at target
						if ( weapons[curWeapon].script.ReadyCheck() == true ) { // early out if weapon isn't ready
							Shoot();
						}
					}
				}
			}
		}
		
		// set angle of weapons to converge based on current target range
		if (dynamicConverge == true && weapons.Length > 0 ) {
			float _convergeRange = Mathf.Clamp(    Vector3.Distance(turretScript.weaponMount.transform.position, turretScript.targetLocation),    minConvergeRange, Mathf.Infinity );
			for (int w = 0; w < weapons.Length; w++) {
				if (weapons[w] != null) {
					Quaternion _rotGoal;
					if (target) { // slew to target
						_rotGoal = Quaternion.LookRotation( turretScript.weaponMount.transform.position +
						                                   (turretScript.weaponMount.transform.forward * _convergeRange) -
						                                   weapons[w].weapon.transform.position, turretScript.weaponMount.transform.up );
					} else { // reset converge to none 
						_rotGoal = Quaternion.LookRotation( weapons[w].weapon.transform.position +
						                                   (turretScript.weaponMount.transform.forward * 1000f) -
						                                   weapons[w].weapon.transform.position, turretScript.weaponMount.transform.up );
					}
					weapons[w].weapon.transform.rotation = Quaternion.RotateTowards( weapons[w].weapon.transform.rotation, _rotGoal, convergeSlewRate * Time.deltaTime );
				}
			}
		}
		
		// set weapons inaccuracy due to turret rotation/elevation
		if ( weapons.Length > 0 ) {
			if ( turretScript.turningWeapInaccuracy > 0 || oldTurnWeapInaccuracy != turretScript.turningWeapInaccuracy ) { // catch setting 0 after being > 0, otherwise the weaps wont get updated
				oldTurnWeapInaccuracy = turretScript.turningWeapInaccuracy;
				if ( oldTurnWeapInaccuracy == 0) {
					turretScript.totalTurnWeapInaccuracy = 0f;
				}
				for (int wi=0; wi < weapons.Length; wi++) {
					weapons[wi].script.curInaccuracy = Mathf.Clamp(   weapons[wi].script.inaccuracy + turretScript.totalTurnWeapInaccuracy,   
					                                               weapons[wi].script.inaccuracy, Mathf.Max(maxInaccuracy, weapons[wi].script.inaccuracy) );
				}
			}
		}
	}
	
	void Shoot() {
		// check line of sight
		bool _losClear = false;
		if (checkLOS == false || controller == ControlType.Player ) { // always clear when not using LOS or under player control
			_losClear = true;
		} else {
			if (Time.time >= lastLosCheck + losCheckInterval) {
				RaycastHit _hit;
				_losClear = false;
				Vector3 targetPos = target.transform.position;
				targetPos.y += 0f; 
				Vector3 _startPos = weapons[curWeapon].script.exits[ weapons[curWeapon].script.curExit ].transform.position;
				if (Physics.Raycast(_startPos, targetPos - _startPos, out _hit, this.GetComponent<WWTD_Tower>().rowData._Range)) {
					if ( _hit.transform.root.gameObject == target ) {
						_losClear = true;
					}
				}
				lastLosCheck = Time.time;
			}
		}
		
		// fire weapons
		if (_losClear == true) {
			float _targetRange = Vector3.Distance(turretScript.weaponMount.transform.position, turretScript.targetLocation);
			if (_targetRange <= this.GetComponent<WWTD_Tower>().rowData._Range) {
				weapons[curWeapon].script.platformVelocity = turretScript.platformVelocity;
				if (alternatingFire == true) { // alternate fire bewteen weapons
					// based on weapons[0] cycle rate. for best results, all weapons should have the same cycle time
					if ( Time.time >= lastFire + (weapons[0].script.cycleTime / weapons.Length) ) { 
						
						weapons[curWeapon].script.DoFire(); // (already checked if weapon is ready)
						
						curWeapon = MFmath.Mod(curWeapon+1, weapons.Length);
						lastFire = Time.time;
					}
				} else { // fire all weapons at once
					for (int sw=0; sw < weapons.Length; sw++) {
						
						weapons[sw].script.Shoot(); // includes ReadyCheck just in case weapons are different or out of sync
					}
				}
			}
		}
	}
	
	bool CheckErrors () {
		error = false;
		string _object = gameObject.name;
		//		if (weapons.Length == 0) { Debug.Log(_object+": TurretControl has 0 weapons."); error = true; }
		if ( weapons.Length > 0 ) {
			for (int cw=0; cw < weapons.Length; cw++) {
				if (weapons[cw].weapon == false) { Debug.Log(_object+": TurretControl weapon index "+cw+" hasn't been defined."); error = true; }
			}
		}
		if ( !GetComponent<MF_AbstractPlatform>() ) { Debug.Log(_object+": No turret script found."); error = true; }
		return error;
	}
}


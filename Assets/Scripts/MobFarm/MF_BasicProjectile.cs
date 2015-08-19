using UnityEngine;
using System.Collections;
using UnitScripts;
using PigeonCoopToolkit.Effects.Trails;
using System.Collections.Generic;
using Creep;

public class MF_BasicProjectile : MonoBehaviour {

	public float damage;
	public float splashDamage;
	public float splashRange;
	public float damageInfantryMultiplier = 1f;
	public float damageMechMultiplier = 1f;
	public float slowPercent = 1f;
	public int slowTime = 1;
	public ETargetType slowType;
	public float bulletThickness = 2f;
	public string awaker = "";
	public string splashTag = "Creeps";
	public static FastPool blastObjectPool;
	public GameObject blastObjectPrefab;
	[HideInInspector] public float duration;
	
	public float startTime;
	
	public void Start() {
		if(blastObjectPool==null||blastObjectPool.ID==0) {
			blastObjectPool = FastPoolManager.GetPool(blastObjectPrefab,true);
		}
	}

	public void Awake() {


	
	}

	public virtual void FixedUpdate () {
		if (Time.time >= startTime + duration) {
			this.gameObject.SetActive(false);
		}


		RaycastHit hit = default(RaycastHit);
		if(Physics.SphereCast(transform.position,this.bulletThickness,GetComponent<Rigidbody>().velocity,out hit,GetComponent<Rigidbody>().velocity.magnitude * Time.fixedDeltaTime, ~(1<<11))) {
			this.gameObject.SetActive(false);
			blastObjectPool.TryGetNextObject(hit.point,Quaternion.identity);
			DoHit( hit.collider.gameObject );
			GameObject[] g = GameObject.FindGameObjectsWithTag(hit.collider.gameObject.tag);
			// Find all objects within splash range
			List<GameObject> objs = new List<GameObject>();
			
			Vector3 orig = hit.collider.gameObject.transform.position;
			for(int i = 0;i<g.Length;i++) {
				float dist = Vector3.Distance(orig,g[i].transform.position);
				if(dist>0f&&dist<this.splashRange) {
					DoSplashHit(g[i],this.splashDamage*this.damage);
				}
			}  
			
		}
	}
	public virtual void OnDisable() {
		Trail t = this.GetComponent<Trail>();
		t.ClearSystem(false);
	}
	public virtual void OnEnable() {
		Trail t = this.GetComponent<Trail>();
		t.Emit = true;
	} 
	protected void DoHit ( GameObject thisObject ) {
		// do stuff to the target object when it gets hit
		if ( thisObject.GetComponent<BasicUnit>() ) {
			thisObject.GetComponent<BasicUnit>().hitUnit(this.damage,this.damageInfantryMultiplier,this.damageMechMultiplier,this.slowPercent,this.slowTime,this.slowType);
		}
	}
	protected void DoSplashHit ( GameObject thisObject , float aDamage) {
		// do stuff to the target object when it gets hit
		if ( thisObject.GetComponent<BasicUnit>() ) {
			thisObject.GetComponent<BasicUnit>().hitUnit(aDamage,this.damageInfantryMultiplier,this.damageMechMultiplier,this.slowPercent,this.slowTime,this.slowType);
		}
	}

}

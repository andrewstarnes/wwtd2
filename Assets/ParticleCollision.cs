using UnityEngine;
using System.Collections;
using UnitScripts;
using Creep;

public class ParticleCollision : MonoBehaviour {

	public float damageToInflict = 1f;
	public float infantryDamageMultiplier = 1f;
	public float tankInfantryMultiplier = 1f;
	public float slowPercent = 0f;
	public int slowTime = 0;
	public ETargetType slowType;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnParticleCollision(GameObject aOther) {
		if(aOther.GetComponent<BasicUnit>()!=null) {
			aOther.GetComponent<BasicUnit>().hitUnit(damageToInflict,infantryDamageMultiplier,tankInfantryMultiplier,this.slowPercent,this.slowTime,slowType);
		}
		
	}
}

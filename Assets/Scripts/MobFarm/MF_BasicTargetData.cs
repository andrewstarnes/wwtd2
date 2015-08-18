﻿using UnityEngine;
using System.Collections;

// if using layers to designate factions, these names need to match the layer name
using UnitScripts;


public enum FactionType { Side0, Side1, Side2, Side3, Creeps, FlyingCreeps, GroundCreepBullseye };

public enum FactionMethodType { Tags, Layers }

[System.Serializable]
public class TargetData { 
	
	public Transform transform;
	public BasicUnit script;
	public float? lastDetected;
	public float? sqrMagnitude;
	public float? range;
	public float? auxValue1;
	public float? auxValue2;

}

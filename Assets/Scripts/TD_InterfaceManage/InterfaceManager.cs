using UnityEngine;
using System.Collections;

public class InterfaceManager : MonoBehaviour {

	// Use this for initialization
	public GameObject inGameInterface;

	public static InterfaceManager REF;
	void Start () {
		REF = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void toggleTowersMenu() {
		
	}
}

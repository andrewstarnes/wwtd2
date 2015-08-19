using UnityEngine;
using System.Collections;
using Google2u;
using InterfaceManage;

public class GameManager : MonoBehaviour {

	public GameObject selectedTowerPrefab;
	// Use this for initialization
	public static GameManager REF;

	public BuyNewTowerMenu towerMenu;
	public int livesRemaining = 1;
	public int usersCash = 100;
	public bool demo = false;
	private GameObject softTower;
	void Start () {
		REF = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void creepEscape() {
		livesRemaining--;
		Debug.Log ("CreepEscape");
		if(livesRemaining<=0) {
			failRound();
		}
	}

	public void failRound() {
		if(!demo)
			InterfaceManagerUtils.failRound();
	}
	public void placeTowerAt(float aX,float aY,float aZ) {
		if(selectedTowerPrefab!=null) {
			InterfaceManagerUtils.cleanAllInterfaceWindows();
			GameObject terrain = GameObject.Find ("Terrain");
			Terrain t1 = terrain.GetComponent<Terrain>();
			float height = t1.SampleHeight(new Vector3(aX,0f,aZ));
	        GameObject nt = (GameObject) Instantiate(selectedTowerPrefab,new Vector3(aX,height,aZ),Quaternion.identity);
			WWTD_Tower t = nt.GetComponent<WWTD_Tower>();
			t.softPlace();
			InterfaceManagerUtils.confirmTowerWindow(t);
			towerMenu.deselectAllTowers();
			selectedTowerPrefab = null;
		}
	}

	public void upgradeTowerAt(GameObject aUpgraded,Vector3 aPosition) {
		
		InterfaceManagerUtils.cleanAllInterfaceWindows();
		GameObject nt = (GameObject) Instantiate(aUpgraded,aPosition,Quaternion.identity);
		WWTD_Tower t = nt.GetComponent<WWTD_Tower>();
		
		t.hardPlace();
		t.hideRange();
	}

	public bool canBuildTower(TowerListRow aData) {
		if(usersCash>=aData._Cost) {
			usersCash -= aData._Cost;
			return true; 
		} else {
			return false;
		}
	}
}

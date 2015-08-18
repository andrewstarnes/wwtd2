using UnityEngine;
using System.Collections;
using Google2u;

public class WWTD_Tower : MonoBehaviour {

	public int towerTypeID = 0;
	public MeshRenderer towerRange;
	public TowerListRow rowData;
	private MF_BasicScanner scanner;
	private ST_Turret turret;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		getComponents();
		setRange();
		if(!scanner.enabled)
			drawRange();

		BoxCollider b = this.GetComponent<BoxCollider>();
		if(b==null) {
			b = this.gameObject.AddComponent<BoxCollider>();
			b.size = new Vector3(4,1,4);
			b.center = new Vector3(0,0.5f,0);
			
		}
		b.isTrigger = true;

	}
	public void OnClick() {
		Debug.Log ("Tower Clicked: "+this.name);
	}

	public void upgradeTower(TowerListRow aNewTower) {
		Destroy(this.gameObject);
		GameManager.REF.upgradeTowerAt((GameObject) Resources.Load("WWTD/Towers/"+aNewTower._Prefab),this.transform.position);
	}
	void getComponents() {
		scanner = this.GetComponent<MF_BasicScanner>();

		for(int i= 0;i<TowerList.Instance.Rows.Count;i++) {
			if(TowerList.Instance.Rows[i]._ID==towerTypeID) {
				rowData = TowerList.Instance.Rows[i];
			}
		}
	}

	public TowerListRow upgradesTo {
		get {
			for(int i = 0;i<TowerList.Instance.Rows.Count;i++) {
				if(TowerList.Instance.Rows[i]._Name==rowData._UpgradesToA) {
					return TowerList.Instance.Rows[i];
				}
			}
			return null;
		}
	}
	public TowerListRow upgradesToB {
		get { 
			for(int i = 0;i<TowerList.Instance.Rows.Count;i++) {
				if(TowerList.Instance.Rows[i]._Name==rowData._UpgradesToB) {
					return TowerList.Instance.Rows[i];
				}
			} 
			return null; 
		}
	}
	void setRange() {
		scanner.detectorRange = rowData._Range; 
		turret = this.GetComponent<ST_Turret>();
		if(turret!=null) {
			turret.rotationRateMax = rowData._RotationRateMax;
			turret.elevationRateMax = rowData._ElevationRateMax;
			turret.rotationAccel = rowData._RotationAccel;
			turret.elevationRateMax = rowData._ElevationRateMax;
			turret.elevationAccel = rowData._ElevationAccel;
		}
	}
	public void softPlace() {
		centerCameraOnMe();
		if(scanner==null) {
			getComponents();
		}
		scanner.enabled = false;
	}
	public void centerCameraOnMe() {
		
		Camera.main.GetComponent<SimpleDrag>().autoScrollToTower(this.gameObject);
	}
	public void hardPlace() {
		if(scanner == null) {
			this.getComponents();
		}
		hideRange();
		setWeapons();
		scanner.enabled = true;
	}
	public void setWeapons() {
		MF_FireWeapon[] weapons = this.GetComponentsInChildren<MF_FireWeapon>();
		for(int i = 0;i<weapons.Length;i++) {
			weapons[i].initWeapon(rowData);
		}
		MF_BasicWeapon[] basicWeapons = this.GetComponentsInChildren<MF_BasicWeapon>();
		for(int i = 0;i<basicWeapons.Length;i++) {
			basicWeapons[i].initTower(rowData); 
		}
		MF_ElectroWeapon[] electroWeapons = this.GetComponentsInChildren<MF_ElectroWeapon>();
		for(int i = 0;i<electroWeapons.Length;i++) {
			electroWeapons[i].initWeapon(rowData);
		}
	}
	public void hideRange() {
		if(this.transform.FindChild("Range")!=null) {
			Destroy(this.transform.FindChild("Range").gameObject);
		}
	}
	void drawRange() {
		if(this.transform.FindChild("Range")==null) {
			GameObject g = Instantiate(Resources.Load("WWTD/Utils/TowerRange")) as GameObject;
			g.transform.parent = this.gameObject.transform;
			g.name = "Range";
		}
		towerRange = this.transform.FindChild("Range").GetComponent<MeshRenderer>();
		towerRange.transform.localPosition = new Vector3(0f,1.2f,0f);

		
		while(towerRange.bounds.extents.x<this.scanner.detectorRange) {
			Vector3 scale = towerRange.transform.localScale;
			scale.x += 0.1f;
			scale.z += 0.1f; 
			towerRange.transform.localScale = scale;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

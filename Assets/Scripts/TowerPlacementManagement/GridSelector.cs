using UnityEngine;
using System.Collections;

public class GridSelector : MonoBehaviour {

	public Camera mouseCamera;
	private GridOverlay overlay;
	public GameObject selectedTowerPrefab;

	public GameObject towerBeingPlaced;
	public GameObject lastObjectHovered;
	public Terrain terrain;
	public static GridSelector REF;
	public Vector3 lastMousePoint = new Vector3(0f,0f,0f);
	// Use this for initialization
	void Start () {
		overlay = this.GetComponent<GridOverlay>();
		REF = this;
		terrain = GameObject.FindGameObjectWithTag("Terrain").GetComponent<Terrain>();
	}
	
	void OnEnable() {
		
		Lean.LeanTouch.OnFingerTap += OnFingerTap;
	}
	void OnDisable() {
		
		Lean.LeanTouch.OnFingerDown -= OnFingerTap;
	}
	// Update is called once per frame
	void Update () {
		Ray ray = mouseCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit rh;;

		Debug.DrawRay(ray.origin,ray.direction,Color.red);
		if(Physics.Raycast(ray.origin,ray.direction,out rh,mouseCamera.transform.position.y*2f)) {
		
			Vector3 p = rh.point;
			p.x = (p.x-terrain.transform.position.x) / (overlay.cellSize);
			p.z = (p.z-terrain.transform.position.z) / (overlay.cellSize);
			p.x = Mathf.FloorToInt(p.x);
			p.z = Mathf.FloorToInt(p.z);
	//		Debug.Log (p);
			
			lastMousePoint.x = p.x;
			lastMousePoint.z = p.z;
			lastObjectHovered = rh.collider.gameObject;
			if(Input.GetMouseButtonDown(1)) {
				overlay.toggleBuildable((int) p.x,(int) p.z);
			} else if(Input.GetMouseButtonDown(0)) {
				
			}
//			Debug.Log (rh.collider.gameObject.name);
		}
	}
	public void OnFingerTap(Lean.LeanFinger finger)
	{
		
		if(Input.GetMouseButtonDown(1)) {
			return;	
		}
		// Does the prefab exist?
		if (selectedTowerPrefab != null)
		{
			// Make sure the finger isn't over any GUI elements
			if (finger.IsOverGui == false)
			{
				// Soft Build this tower, show it's range and stuff but don't let it shoot until we've held down for a second.
				if(towerBeingPlaced!=null) {
					Destroy(towerBeingPlaced);
					towerBeingPlaced = null;
				}
				if(lastObjectHovered.name=="Terrain") {
					GameObject b = buildTower((int) lastMousePoint.x,(int) lastMousePoint.z);
				} else {
					WWTD_Tower t = lastObjectHovered.GetComponent<WWTD_Tower>();
					if(t!=null) {
						t.centerCameraOnMe();
						InterfaceManagerUtils.showUpgradeTower(t);
					}
				} 

			}
		}
	}

	public void drawOverlay(bool aShowOverlay) {
		overlay.gameObject.SetActive(aShowOverlay);
	}
	public void setBuildableAtPosition(float aX,float aY,float aZ,bool aNewValue) {

		Vector3 origin = new Vector3(aX,aY,aZ);
		RaycastHit rh;
		if(Physics.Raycast(origin,Vector3.down,out rh,100000f)) {
			
			Vector3 p = rh.point;
			p.x = (p.x-terrain.transform.position.x) / (overlay.cellSize);
			p.z = (p.z-terrain.transform.position.z) / (overlay.cellSize);
			p.x = Mathf.FloorToInt(p.x);
			p.z = Mathf.FloorToInt(p.z);
			overlay.buildable[(int) p.z*overlay.gridWidth+(int) p.x] = aNewValue;
			overlay.UpdateCells();
			lastMousePoint.x = p.x;
			lastMousePoint.z = p.z;
		}	
	}
	public GameObject buildTower(int aSquareX,int aSquareZ) {
		Debug.Log ("BuildTower: "+aSquareX+","+aSquareZ);
		float xPos = (float) (aSquareX)*overlay.cellSize+(overlay.cellSize/2)+terrain.transform.position.x;
		float zPos = (float) (aSquareZ)*overlay.cellSize+(overlay.cellSize/2)+terrain.transform.position.z;
		if(overlay.buildable[aSquareZ*overlay.gridWidth+aSquareX]) {
			GameManager.REF.placeTowerAt(xPos,overlay.heights[aSquareZ+overlay.gridWidth+aSquareX]-1f,zPos);

		}
		return null;

	}
}

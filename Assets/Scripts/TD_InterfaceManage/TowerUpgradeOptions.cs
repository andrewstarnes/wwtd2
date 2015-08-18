using UnityEngine;
using System.Collections;
using Google2u;

public class TowerUpgradeOptions : MonoBehaviour {

	// Use this for initialization
	public WWTD_Tower thisTower;
	public static float lastBuyTime = 0;
	public const float minTimesBetweenBuy = 0.1f;
	public UILabel upgradeAPriceLabel;
	public UILabel towerNameLabel;
	public UILabel towerDescription;

	public UILabel upgradeALabel;
	public GameObject upgradeABtn;
	public GameObject upgradeBBtn;

	public UILabel upgradeBPriceLabel;
	public UILabel upgradeBLabel;
	void Start () {
		GameObject g = this.transform.FindChild("TowerUpgradeArea").gameObject;
		g.transform.localScale = new Vector3(0f,0f,0f);
		iTween.ScaleTo(g,new Vector3(1f,1f,1f),0.5f);
		this.tag = "UIWindow";
	}
	

	public void initTower(WWTD_Tower aTower) {
		thisTower = aTower;
		if(Time.time-lastBuyTime<minTimesBetweenBuy) {
			Destroy(this.gameObject);
		}
		TowerListRow t = aTower.upgradesTo;
		if(t!=null) {
			
			upgradeABtn.gameObject.SetActive(true);
			upgradeAPriceLabel.text = t._Cost.ToString("C0");
			upgradeALabel.text = "UPGRADE: "+t._Name.ToUpper();
		} else {
			upgradeABtn.gameObject.SetActive(false);
		}
		t = aTower.upgradesToB;
		if(t != null) {
			upgradeBBtn.gameObject.SetActive(true);
			this.upgradeBPriceLabel.text = t._Cost.ToString("C0");
			upgradeBLabel.text = "UPGRADE: "+t._Name.ToUpper();
		} else {
			upgradeBBtn.gameObject.SetActive(false);
		}
		towerNameLabel.text = aTower.rowData._Name.ToUpper();
		towerDescription.text = aTower.rowData._Description;
	}

	public void onUpgradeATower() {
		if(GameManager.REF.canBuildTower(thisTower.rowData)) {
			thisTower.upgradeTower(thisTower.upgradesTo);
			lastBuyTime = Time.time;
			Destroy(this.gameObject);
		}
	}
	public void onBuyTower() {
		if(GameManager.REF.canBuildTower(thisTower.rowData)) {
			thisTower.hardPlace();
		
			GridSelector.REF.setBuildableAtPosition(thisTower.transform.position.x,100f,thisTower.transform.position.z,false);
			thisTower = null;
			lastBuyTime = Time.time;
			Destroy(this.gameObject);
		}
	}

	public void OnDestroy() {

	}
	public void onCancelTower() {
		Destroy(this.gameObject);
	}
}

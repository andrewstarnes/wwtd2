//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class TowerListRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _Prefab;
		public string _SpriteName;
		public string _Description;
		public int _Cost;
		public string _UpgradesToA;
		public string _UpgradesToB;
		public string _Targets;
		public int _Range;
		public float _DetectorInterval;
		public int _ShotSpeed;
		public int _MaxRange;
		public float _CycleTime;
		public int _BurstAmount;
		public float _BurstResetTime;
		public int _ShotsPerRound;
		public float _ReloadTime;
		public string _BulletName;
		public float _BulletDamage;
		public float _BulletSplash;
		public float _BulletSplashRange;
		public float _BulletArmorModifier;
		public float _BulletInfantryModifier;
		public float _BulletSlowPercent;
		public string _SlowTarget;
		public int _BulletSlowTime;
		public int _BaseTowerType;
		public int _RotationRateMax;
		public int _ElevationRateMax;
		public int _RotationAccel;
		public int _ElevationAccel;
		public float _DecelerateMulti;
		public TowerListRow(string __GOOGLEFU_ID, string __ID, string __Name, string __Prefab, string __SpriteName, string __Description, string __Cost, string __UpgradesToA, string __UpgradesToB, string __Targets, string __Range, string __DetectorInterval, string __ShotSpeed, string __MaxRange, string __CycleTime, string __BurstAmount, string __BurstResetTime, string __ShotsPerRound, string __ReloadTime, string __BulletName, string __BulletDamage, string __BulletSplash, string __BulletSplashRange, string __BulletArmorModifier, string __BulletInfantryModifier, string __BulletSlowPercent, string __SlowTarget, string __BulletSlowTime, string __BaseTowerType, string __RotationRateMax, string __ElevationRateMax, string __RotationAccel, string __ElevationAccel, string __DecelerateMulti) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_Prefab = __Prefab.Trim();
			_SpriteName = __SpriteName.Trim();
			_Description = __Description.Trim();
			{
			int res;
				if(int.TryParse(__Cost, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Cost = res;
				else
					Debug.LogError("Failed To Convert _Cost string: "+ __Cost +" to int");
			}
			_UpgradesToA = __UpgradesToA.Trim();
			_UpgradesToB = __UpgradesToB.Trim();
			_Targets = __Targets.Trim();
			{
			int res;
				if(int.TryParse(__Range, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Range = res;
				else
					Debug.LogError("Failed To Convert _Range string: "+ __Range +" to int");
			}
			{
			float res;
				if(float.TryParse(__DetectorInterval, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DetectorInterval = res;
				else
					Debug.LogError("Failed To Convert _DetectorInterval string: "+ __DetectorInterval +" to float");
			}
			{
			int res;
				if(int.TryParse(__ShotSpeed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ShotSpeed = res;
				else
					Debug.LogError("Failed To Convert _ShotSpeed string: "+ __ShotSpeed +" to int");
			}
			{
			int res;
				if(int.TryParse(__MaxRange, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MaxRange = res;
				else
					Debug.LogError("Failed To Convert _MaxRange string: "+ __MaxRange +" to int");
			}
			{
			float res;
				if(float.TryParse(__CycleTime, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CycleTime = res;
				else
					Debug.LogError("Failed To Convert _CycleTime string: "+ __CycleTime +" to float");
			}
			{
			int res;
				if(int.TryParse(__BurstAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BurstAmount = res;
				else
					Debug.LogError("Failed To Convert _BurstAmount string: "+ __BurstAmount +" to int");
			}
			{
			float res;
				if(float.TryParse(__BurstResetTime, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BurstResetTime = res;
				else
					Debug.LogError("Failed To Convert _BurstResetTime string: "+ __BurstResetTime +" to float");
			}
			{
			int res;
				if(int.TryParse(__ShotsPerRound, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ShotsPerRound = res;
				else
					Debug.LogError("Failed To Convert _ShotsPerRound string: "+ __ShotsPerRound +" to int");
			}
			{
			float res;
				if(float.TryParse(__ReloadTime, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ReloadTime = res;
				else
					Debug.LogError("Failed To Convert _ReloadTime string: "+ __ReloadTime +" to float");
			}
			_BulletName = __BulletName.Trim();
			{
			float res;
				if(float.TryParse(__BulletDamage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletDamage = res;
				else
					Debug.LogError("Failed To Convert _BulletDamage string: "+ __BulletDamage +" to float");
			}
			{
			float res;
				if(float.TryParse(__BulletSplash, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletSplash = res;
				else
					Debug.LogError("Failed To Convert _BulletSplash string: "+ __BulletSplash +" to float");
			}
			{
			float res;
				if(float.TryParse(__BulletSplashRange, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletSplashRange = res;
				else
					Debug.LogError("Failed To Convert _BulletSplashRange string: "+ __BulletSplashRange +" to float");
			}
			{
			float res;
				if(float.TryParse(__BulletArmorModifier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletArmorModifier = res;
				else
					Debug.LogError("Failed To Convert _BulletArmorModifier string: "+ __BulletArmorModifier +" to float");
			}
			{
			float res;
				if(float.TryParse(__BulletInfantryModifier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletInfantryModifier = res;
				else
					Debug.LogError("Failed To Convert _BulletInfantryModifier string: "+ __BulletInfantryModifier +" to float");
			}
			{
			float res;
				if(float.TryParse(__BulletSlowPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletSlowPercent = res;
				else
					Debug.LogError("Failed To Convert _BulletSlowPercent string: "+ __BulletSlowPercent +" to float");
			}
			_SlowTarget = __SlowTarget.Trim();
			{
			int res;
				if(int.TryParse(__BulletSlowTime, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BulletSlowTime = res;
				else
					Debug.LogError("Failed To Convert _BulletSlowTime string: "+ __BulletSlowTime +" to int");
			}
			{
			int res;
				if(int.TryParse(__BaseTowerType, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BaseTowerType = res;
				else
					Debug.LogError("Failed To Convert _BaseTowerType string: "+ __BaseTowerType +" to int");
			}
			{
			int res;
				if(int.TryParse(__RotationRateMax, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RotationRateMax = res;
				else
					Debug.LogError("Failed To Convert _RotationRateMax string: "+ __RotationRateMax +" to int");
			}
			{
			int res;
				if(int.TryParse(__ElevationRateMax, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElevationRateMax = res;
				else
					Debug.LogError("Failed To Convert _ElevationRateMax string: "+ __ElevationRateMax +" to int");
			}
			{
			int res;
				if(int.TryParse(__RotationAccel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RotationAccel = res;
				else
					Debug.LogError("Failed To Convert _RotationAccel string: "+ __RotationAccel +" to int");
			}
			{
			int res;
				if(int.TryParse(__ElevationAccel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElevationAccel = res;
				else
					Debug.LogError("Failed To Convert _ElevationAccel string: "+ __ElevationAccel +" to int");
			}
			{
			float res;
				if(float.TryParse(__DecelerateMulti, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DecelerateMulti = res;
				else
					Debug.LogError("Failed To Convert _DecelerateMulti string: "+ __DecelerateMulti +" to float");
			}
		}

		public int Length { get { return 33; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _ID.ToString();
					break;
				case 1:
					ret = _Name.ToString();
					break;
				case 2:
					ret = _Prefab.ToString();
					break;
				case 3:
					ret = _SpriteName.ToString();
					break;
				case 4:
					ret = _Description.ToString();
					break;
				case 5:
					ret = _Cost.ToString();
					break;
				case 6:
					ret = _UpgradesToA.ToString();
					break;
				case 7:
					ret = _UpgradesToB.ToString();
					break;
				case 8:
					ret = _Targets.ToString();
					break;
				case 9:
					ret = _Range.ToString();
					break;
				case 10:
					ret = _DetectorInterval.ToString();
					break;
				case 11:
					ret = _ShotSpeed.ToString();
					break;
				case 12:
					ret = _MaxRange.ToString();
					break;
				case 13:
					ret = _CycleTime.ToString();
					break;
				case 14:
					ret = _BurstAmount.ToString();
					break;
				case 15:
					ret = _BurstResetTime.ToString();
					break;
				case 16:
					ret = _ShotsPerRound.ToString();
					break;
				case 17:
					ret = _ReloadTime.ToString();
					break;
				case 18:
					ret = _BulletName.ToString();
					break;
				case 19:
					ret = _BulletDamage.ToString();
					break;
				case 20:
					ret = _BulletSplash.ToString();
					break;
				case 21:
					ret = _BulletSplashRange.ToString();
					break;
				case 22:
					ret = _BulletArmorModifier.ToString();
					break;
				case 23:
					ret = _BulletInfantryModifier.ToString();
					break;
				case 24:
					ret = _BulletSlowPercent.ToString();
					break;
				case 25:
					ret = _SlowTarget.ToString();
					break;
				case 26:
					ret = _BulletSlowTime.ToString();
					break;
				case 27:
					ret = _BaseTowerType.ToString();
					break;
				case 28:
					ret = _RotationRateMax.ToString();
					break;
				case 29:
					ret = _ElevationRateMax.ToString();
					break;
				case 30:
					ret = _RotationAccel.ToString();
					break;
				case 31:
					ret = _ElevationAccel.ToString();
					break;
				case 32:
					ret = _DecelerateMulti.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "ID":
					ret = _ID.ToString();
					break;
				case "Name":
					ret = _Name.ToString();
					break;
				case "Prefab":
					ret = _Prefab.ToString();
					break;
				case "SpriteName":
					ret = _SpriteName.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "Cost":
					ret = _Cost.ToString();
					break;
				case "UpgradesToA":
					ret = _UpgradesToA.ToString();
					break;
				case "UpgradesToB":
					ret = _UpgradesToB.ToString();
					break;
				case "Targets":
					ret = _Targets.ToString();
					break;
				case "Range":
					ret = _Range.ToString();
					break;
				case "DetectorInterval":
					ret = _DetectorInterval.ToString();
					break;
				case "ShotSpeed":
					ret = _ShotSpeed.ToString();
					break;
				case "MaxRange":
					ret = _MaxRange.ToString();
					break;
				case "CycleTime":
					ret = _CycleTime.ToString();
					break;
				case "BurstAmount":
					ret = _BurstAmount.ToString();
					break;
				case "BurstResetTime":
					ret = _BurstResetTime.ToString();
					break;
				case "ShotsPerRound":
					ret = _ShotsPerRound.ToString();
					break;
				case "ReloadTime":
					ret = _ReloadTime.ToString();
					break;
				case "BulletName":
					ret = _BulletName.ToString();
					break;
				case "BulletDamage":
					ret = _BulletDamage.ToString();
					break;
				case "BulletSplash":
					ret = _BulletSplash.ToString();
					break;
				case "BulletSplashRange":
					ret = _BulletSplashRange.ToString();
					break;
				case "BulletArmorModifier":
					ret = _BulletArmorModifier.ToString();
					break;
				case "BulletInfantryModifier":
					ret = _BulletInfantryModifier.ToString();
					break;
				case "BulletSlowPercent":
					ret = _BulletSlowPercent.ToString();
					break;
				case "SlowTarget":
					ret = _SlowTarget.ToString();
					break;
				case "BulletSlowTime":
					ret = _BulletSlowTime.ToString();
					break;
				case "BaseTowerType":
					ret = _BaseTowerType.ToString();
					break;
				case "RotationRateMax":
					ret = _RotationRateMax.ToString();
					break;
				case "ElevationRateMax":
					ret = _ElevationRateMax.ToString();
					break;
				case "RotationAccel":
					ret = _RotationAccel.ToString();
					break;
				case "ElevationAccel":
					ret = _ElevationAccel.ToString();
					break;
				case "DecelerateMulti":
					ret = _DecelerateMulti.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Prefab" + " : " + _Prefab.ToString() + "} ";
			ret += "{" + "SpriteName" + " : " + _SpriteName.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "Cost" + " : " + _Cost.ToString() + "} ";
			ret += "{" + "UpgradesToA" + " : " + _UpgradesToA.ToString() + "} ";
			ret += "{" + "UpgradesToB" + " : " + _UpgradesToB.ToString() + "} ";
			ret += "{" + "Targets" + " : " + _Targets.ToString() + "} ";
			ret += "{" + "Range" + " : " + _Range.ToString() + "} ";
			ret += "{" + "DetectorInterval" + " : " + _DetectorInterval.ToString() + "} ";
			ret += "{" + "ShotSpeed" + " : " + _ShotSpeed.ToString() + "} ";
			ret += "{" + "MaxRange" + " : " + _MaxRange.ToString() + "} ";
			ret += "{" + "CycleTime" + " : " + _CycleTime.ToString() + "} ";
			ret += "{" + "BurstAmount" + " : " + _BurstAmount.ToString() + "} ";
			ret += "{" + "BurstResetTime" + " : " + _BurstResetTime.ToString() + "} ";
			ret += "{" + "ShotsPerRound" + " : " + _ShotsPerRound.ToString() + "} ";
			ret += "{" + "ReloadTime" + " : " + _ReloadTime.ToString() + "} ";
			ret += "{" + "BulletName" + " : " + _BulletName.ToString() + "} ";
			ret += "{" + "BulletDamage" + " : " + _BulletDamage.ToString() + "} ";
			ret += "{" + "BulletSplash" + " : " + _BulletSplash.ToString() + "} ";
			ret += "{" + "BulletSplashRange" + " : " + _BulletSplashRange.ToString() + "} ";
			ret += "{" + "BulletArmorModifier" + " : " + _BulletArmorModifier.ToString() + "} ";
			ret += "{" + "BulletInfantryModifier" + " : " + _BulletInfantryModifier.ToString() + "} ";
			ret += "{" + "BulletSlowPercent" + " : " + _BulletSlowPercent.ToString() + "} ";
			ret += "{" + "SlowTarget" + " : " + _SlowTarget.ToString() + "} ";
			ret += "{" + "BulletSlowTime" + " : " + _BulletSlowTime.ToString() + "} ";
			ret += "{" + "BaseTowerType" + " : " + _BaseTowerType.ToString() + "} ";
			ret += "{" + "RotationRateMax" + " : " + _RotationRateMax.ToString() + "} ";
			ret += "{" + "ElevationRateMax" + " : " + _ElevationRateMax.ToString() + "} ";
			ret += "{" + "RotationAccel" + " : " + _RotationAccel.ToString() + "} ";
			ret += "{" + "ElevationAccel" + " : " + _ElevationAccel.ToString() + "} ";
			ret += "{" + "DecelerateMulti" + " : " + _DecelerateMulti.ToString() + "} ";
			return ret;
		}
	}
	public sealed class TowerList : IGoogle2uDB
	{
		public enum rowIds {
			TOWER_1, TOWER_2, TOWER_3, TOWER_4, TOWER_5, TOWER_6, TOWER_7, TOWER_8, TOWER_9, TOWER_10, TOWER_11, TOWER_12, TOWER_13, TOWER_14, TOWER_15, TOWER_16, TOWER_17, TOWER_18
			, TOWER_19, TOWER_20, TOWER_21, TOWER_22, TOWER_23, TOWER_24, TOWER_25, TOWER_26, TOWER_27, TOWER_28, TOWER_29, TOWER_30, TOWER_31, TOWER_32, TOWER_33, TOWER_34, TOWER_35, TOWER_36
		};
		public string [] rowNames = {
			"TOWER_1", "TOWER_2", "TOWER_3", "TOWER_4", "TOWER_5", "TOWER_6", "TOWER_7", "TOWER_8", "TOWER_9", "TOWER_10", "TOWER_11", "TOWER_12", "TOWER_13", "TOWER_14", "TOWER_15", "TOWER_16", "TOWER_17", "TOWER_18"
			, "TOWER_19", "TOWER_20", "TOWER_21", "TOWER_22", "TOWER_23", "TOWER_24", "TOWER_25", "TOWER_26", "TOWER_27", "TOWER_28", "TOWER_29", "TOWER_30", "TOWER_31", "TOWER_32", "TOWER_33", "TOWER_34", "TOWER_35", "TOWER_36"
		};
		public System.Collections.Generic.List<TowerListRow> Rows = new System.Collections.Generic.List<TowerListRow>();

		public static TowerList Instance
		{
			get { return NestedTowerList.instance; }
		}

		private class NestedTowerList
		{
			static NestedTowerList() { }
			internal static readonly TowerList instance = new TowerList();
		}

		private TowerList()
		{
			Rows.Add( new TowerListRow("TOWER_1", "1", "Basic Tower 1", "Tow_Basic1", "fasttower", "Fast rate of fire with low damage.", "10", "Basic Tower 2", "", "Both", "30", "1", "100", "100", "0.1", "3", "0.3", "1", "0.5", "BulletPool", "1", "0", "0", "1", "0.8", "0", "", "0", "0", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_2", "2", "Basic Tower 2", "Tow_Basic2", "fasttower", "Fast rate of fire with low damage.", "15", "Basic Tower 3", "", "Both", "34", "0.9", "100", "100", "0", "0", "1", "1", "0.4", "BulletPool", "2", "0", "0", "1", "0.8", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_3", "3", "Basic Tower 3", "Tow_Basic3", "fasttower", "Fast rate of fire with low damage.", "30", "Basic Tower 4", "", "Both", "38", "0.8", "100", "100", "0", "0", "1", "1", "0.3", "BulletPool", "3", "0", "0", "1", "0.8", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_4", "4", "Basic Tower 4", "Tow_Basic4", "fasttower", "Fast rate of fire with low damage.", "80", "Basic Tower 5", "", "Both", "42", "0.7", "100", "100", "0", "0", "1", "1", "0.2", "BulletPool", "4", "0", "0", "1", "0.8", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_5", "5", "Basic Tower 5", "Tow_Basic5", "fasttower", "Fast rate of fire with low damage.", "120", "Basic Tower 6", "", "Both", "46", "0.6", "100", "100", "0", "0", "1", "1", "0.1", "BulletPool", "5", "0", "0", "1", "0.8", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_6", "6", "Basic Tower 6", "Tow_Basic6", "fasttower", "Fast rate of fire with low damage.", "250", "", "", "Both", "50", "0.5", "100", "100", "0", "0", "1", "1", "0.05", "BulletPool", "6", "0", "0", "1", "0.8", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_7", "7", "Fire Tower 1", "Tow_Fire1", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "15", "Fire Tower 2", "", "Ground", "17", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.05", "0", "0", "0.1", "1", "0", "", "0", "1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_8", "8", "Fire Tower 2", "Tow_Fire2", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "10", "Fire Tower 3", "", "Ground", "18", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.09", "0", "0", "0.1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_9", "9", "Fire Tower 3", "Tow_Fire3", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "30", "Fire Tower 4", "", "Ground", "19", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.15", "0", "0", "0.1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_10", "10", "Fire Tower 4", "Tow_Fire4", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "50", "Fire Tower 5", "", "Ground", "20", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.2", "0", "0", "0.1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_11", "11", "Fire Tower 5", "Tow_Fire5", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "90", "Fire Tower 6", "", "Ground", "21", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.25", "0", "0", "0.1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_12", "12", "Fire Tower 6", "Tow_Fire6", "firetower", "Flamethrower tower, small range, excellent vs Infantry", "140", "", "", "Ground", "22", "1", "100", "100", "0", "0", "1", "1", "2", "FlameThrower", "0.4", "0", "0", "0.1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_13", "13", "Laser Tower 1", "Tow_Laser1", "lasertower", "Can destroy lines of units in one blast", "40", "Laser Tower 2", "", "Ground", "30", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "15", "0", "0", "1", "1", "0", "", "0", "2", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_14", "14", "Laser Tower 2", "Tow_Laser2", "lasertower", "Can destroy lines of units in one blast", "30", "Laser Tower 3", "", "Ground", "34", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "20", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_15", "15", "Laser Tower 3", "Tow_Laser3", "lasertower", "Can destroy lines of units in one blast", "70", "Laser Tower 4A", "Laser Tower 4B", "Ground", "38", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "25", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_16", "16", "Laser Tower 4A", "Tow_Laser4a", "lasertower", "Can destroy lines of units in one blast", "110", "Laser Tower 5A", "", "Ground", "42", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "40", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_17", "17", "Laser Tower 5A", "Tow_Laser5a", "lasertower", "Can destroy lines of units in one blast", "150", "Laser Tower 6A", "", "Ground", "46", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "60", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_18", "18", "Laser Tower 6A", "Tow_Laser6a", "lasertower", "Can destroy lines of units in one blast", "300", "", "", "Ground", "50", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "90", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_19", "19", "Laser Tower 4B", "Tow_Laser4a", "lasertower", "Can destroy lines of units in one blast", "70", "Laser Tower 5B", "", "Ground", "54", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "40", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_20", "20", "Laser Tower 5B", "Tow_Laser5a", "lasertower", "Can destroy lines of units in one blast", "110", "Laser Tower 6B", "", "Ground", "58", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "60", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_21", "21", "Laser Tower 6B", "Tow_Laser6a", "lasertower", "Can destroy lines of units in one blast", "150", "", "", "Ground", "62", "1", "150", "3000", "0", "0", "1", "1", "3", "Laser", "90", "0", "0", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_22", "22", "Mortar Tower 1", "Tow_Mortar1", "mortar", "Strong powerful weapon that has good splash damage.", "30", "Mortar Tower 2", "", "Ground", "66", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "10", "0.5", "10", "1", "1", "0", "", "0", "3", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_23", "23", "Mortar Tower 2", "Tow_Mortar2", "mortar", "Strong powerful weapon that has good splash damage.", "20", "Mortar Tower 3", "", "Ground", "70", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "20", "0.6", "15", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_24", "24", "Mortar Tower 3", "Tow_Mortar3", "mortar", "Strong powerful weapon that has good splash damage.", "50", "Mortar Tower 4A", "Mortar Tower 4B", "Ground", "74", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "40", "0.7", "20", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_25", "25", "Mortar Tower 4A", "Tow_Mortar4a", "mortar", "Strong powerful weapon that has good splash damage.", "90", "Mortar Tower 5B", "", "Ground", "78", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "80", "0.8", "25", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_26", "26", "Mortar Tower 5A", "Tow_Mortar5a", "mortar", "Strong powerful weapon that has good splash damage.", "150", "Mortar Tower 6B", "", "Ground", "82", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "120", "0.9", "30", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_27", "27", "Mortar Tower 6A", "Tow_Mortar6a", "mortar", "Strong powerful weapon that has good splash damage.", "300", "", "", "Ground", "86", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "160", "1", "35", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_28", "28", "Mortar Tower 4B", "Tow_Mortar4b", "mortar", "Strong powerful weapon that has good splash damage.", "390", "Mortar Tower 5B", "", "Ground", "90", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "200", "0.7", "25", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_29", "29", "Mortar Tower 5B", "Tow_Mortar5b", "mortar", "Strong powerful weapon that has good splash damage.", "495", "Mortar Tower 6B", "", "Ground", "94", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "240", "0.8", "30", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_30", "30", "Mortar Tower 6B", "Tow_Mortar6b", "mortar", "Strong powerful weapon that has good splash damage.", "600", "", "", "Ground", "98", "1", "40", "100", "0", "0", "1", "1", "10", "Cannon", "280", "0.9", "35", "1", "1", "0", "", "0", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_31", "31", "Electric Tower 1", "Tow_Electric1", "radar", "Slows Mechanical Units, Destroys Infantry", "100", "Electric Tower 2", "", "Ground", "20", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "7", "0", "0", "0", "1", "0.5", "AnyMechanical", "100", "4", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_32", "32", "Electric Tower 2", "Tow_Electric2", "radar", "Slows Mechanical Units, Destroys Infantry", "150", "Electric Tower 3", "", "Ground", "21", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "12", "0", "0", "0", "1", "0.4", "AnyMechanical", "135", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_33", "33", "Electric Tower 3", "Tow_Electric3", "radar", "Slows Mechanical Units, Destroys Infantry", "300", "Electric Tower 4", "", "Ground", "22", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "18", "0", "0", "0", "1", "0.3", "AnyMechanical", "200", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_34", "34", "Electric Tower 4", "Tow_Electric4", "radar", "Slows Mechanical Units, Destroys Infantry", "500", "Electric Tower 5", "", "Ground", "23", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "25", "0", "0", "0", "1", "0.2", "AnyMechanical", "250", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_35", "35", "Electric Tower 5", "Tow_Electric5", "radar", "Slows Mechanical Units, Destroys Infantry", "800", "Electric Tower 6", "", "Ground", "24", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "40", "0", "0", "0", "1", "0.1", "AnyMechanical", "300", "-1", "300", "400", "25", "25", "2"));
			Rows.Add( new TowerListRow("TOWER_36", "36", "Electric Tower 6", "Tow_Electric6", "radar", "Slows Mechanical Units, Destroys Infantry", "1000", "", "", "Ground", "25", "1", "40", "100", "0", "0", "1", "1", "10", "Electric", "80", "0", "0", "0", "1", "0.01", "AnyMechanical", "350", "-1", "300", "400", "25", "25", "2"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public TowerListRow GetRow(rowIds in_RowID)
		{
			TowerListRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public TowerListRow GetRow(string in_RowString)
		{
			TowerListRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}

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
	public class CreepsListRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _Prefab;
		public int _HitPoints;
		public bool _IsMechanical;
		public bool _IsFlying;
		public int _Value;
		public float _UnitSpeed;
		public CreepsListRow(string __GOOGLEFU_ID, string __ID, string __Name, string __Prefab, string __HitPoints, string __IsMechanical, string __IsFlying, string __Value, string __UnitSpeed) 
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
			{
			int res;
				if(int.TryParse(__HitPoints, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HitPoints = res;
				else
					Debug.LogError("Failed To Convert _HitPoints string: "+ __HitPoints +" to int");
			}
			{
			bool res;
				if(bool.TryParse(__IsMechanical, out res))
					_IsMechanical = res;
				else
					Debug.LogError("Failed To Convert _IsMechanical string: "+ __IsMechanical +" to bool");
			}
			{
			bool res;
				if(bool.TryParse(__IsFlying, out res))
					_IsFlying = res;
				else
					Debug.LogError("Failed To Convert _IsFlying string: "+ __IsFlying +" to bool");
			}
			{
			int res;
				if(int.TryParse(__Value, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Value = res;
				else
					Debug.LogError("Failed To Convert _Value string: "+ __Value +" to int");
			}
			{
			float res;
				if(float.TryParse(__UnitSpeed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_UnitSpeed = res;
				else
					Debug.LogError("Failed To Convert _UnitSpeed string: "+ __UnitSpeed +" to float");
			}
		}

		public int Length { get { return 8; } }

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
					ret = _HitPoints.ToString();
					break;
				case 4:
					ret = _IsMechanical.ToString();
					break;
				case 5:
					ret = _IsFlying.ToString();
					break;
				case 6:
					ret = _Value.ToString();
					break;
				case 7:
					ret = _UnitSpeed.ToString();
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
				case "HitPoints":
					ret = _HitPoints.ToString();
					break;
				case "IsMechanical":
					ret = _IsMechanical.ToString();
					break;
				case "IsFlying":
					ret = _IsFlying.ToString();
					break;
				case "Value":
					ret = _Value.ToString();
					break;
				case "UnitSpeed":
					ret = _UnitSpeed.ToString();
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
			ret += "{" + "HitPoints" + " : " + _HitPoints.ToString() + "} ";
			ret += "{" + "IsMechanical" + " : " + _IsMechanical.ToString() + "} ";
			ret += "{" + "IsFlying" + " : " + _IsFlying.ToString() + "} ";
			ret += "{" + "Value" + " : " + _Value.ToString() + "} ";
			ret += "{" + "UnitSpeed" + " : " + _UnitSpeed.ToString() + "} ";
			return ret;
		}
	}
	public sealed class CreepsList : IGoogle2uDB
	{
		public enum rowIds {
			CREEP_1, CREEP_2, CREEP_3, CREEP_4, CREEP_5, CREEP_6, CREEP_7, CREEP_8, CREEP_9, CREEP_10, CREEP_11, CREEP_12, CREEP_13
		};
		public string [] rowNames = {
			"CREEP_1", "CREEP_2", "CREEP_3", "CREEP_4", "CREEP_5", "CREEP_6", "CREEP_7", "CREEP_8", "CREEP_9", "CREEP_10", "CREEP_11", "CREEP_12", "CREEP_13"
		};
		public System.Collections.Generic.List<CreepsListRow> Rows = new System.Collections.Generic.List<CreepsListRow>();

		public static CreepsList Instance
		{
			get { return NestedCreepsList.instance; }
		}

		private class NestedCreepsList
		{
			static NestedCreepsList() { }
			internal static readonly CreepsList instance = new CreepsList();
		}

		private CreepsList()
		{
			Rows.Add( new CreepsListRow("CREEP_1", "1", "Basic Infantry", "Infantry_Basic", "5", "FALSE", "FALSE", "1", "6"));
			Rows.Add( new CreepsListRow("CREEP_2", "2", "Reconnaissance", "Infantry_Basic", "1", "FALSE", "FALSE", "1", "8"));
			Rows.Add( new CreepsListRow("CREEP_3", "3", "Waffen SS", "Infantry_Basic", "10", "FALSE", "FALSE", "2", "7"));
			Rows.Add( new CreepsListRow("CREEP_4", "4", "Japanese Infantry", "Infantry_Basic", "7", "FALSE", "FALSE", "1", "7"));
			Rows.Add( new CreepsListRow("CREEP_5", "5", "Hetzer Tank", "Tank_Hetzer", "20", "FALSE", "FALSE", "5", "6"));
			Rows.Add( new CreepsListRow("CREEP_6", "6", "Panzer IV Tank", "Tank_PanzerIV", "30", "FALSE", "FALSE", "6", "7"));
			Rows.Add( new CreepsListRow("CREEP_7", "7", "Panther G Tank", "Tank_PantherG", "40", "FALSE", "FALSE", "6", "8"));
			Rows.Add( new CreepsListRow("CREEP_8", "8", "Panzer 4J Tank", "Tank_PanzerIV", "30", "FALSE", "FALSE", "5", "7"));
			Rows.Add( new CreepsListRow("CREEP_9", "9", "StugIII Tank", "Tank_StugIII", "25", "FALSE", "FALSE", "4", "8"));
			Rows.Add( new CreepsListRow("CREEP_10", "10", "SturmgeschutzIll Tank", "Tank_SturmgeschutzIll", "30", "FALSE", "FALSE", "5", "7"));
			Rows.Add( new CreepsListRow("CREEP_11", "11", "Tiger Tank", "Tank_Tiger", "60", "FALSE", "FALSE", "7", "6"));
			Rows.Add( new CreepsListRow("CREEP_12", "12", "ME109", "Me109", "10", "TRUE", "TRUE", "5", "14"));
			Rows.Add( new CreepsListRow("CREEP_13", "13", "ME262", "Me262", "30", "TRUE", "TRUE", "8", "10"));
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
		public CreepsListRow GetRow(rowIds in_RowID)
		{
			CreepsListRow ret = null;
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
		public CreepsListRow GetRow(string in_RowString)
		{
			CreepsListRow ret = null;
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

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;


namespace FlightPathManager
{
	#if UNITY_EDITOR
	using UnityEditor;
	[CustomEditor(typeof(FlightPath))] 
	public class FlightPathHandle : Editor
	{
		public FlightPathHandle ()
		{
		}
		void OnSceneGUI () {
			FlightPath myTarget = (FlightPath) target;
			if(myTarget.path.Length>=1)
				Handles.DrawLine(myTarget.transform.position,myTarget.path[0].transform.position);
			for(var i = 0; i < myTarget.path.Length-1; i++) {
				Handles.DrawLine(myTarget.path[i].transform.position, 
				                 myTarget.path[i+1].transform.position);
			}
		}
	}
	#endif
	
}

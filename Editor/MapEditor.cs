// https://www.youtube.com/watch?v=q7BL-lboRXo&list=PLFt_AvWsXl0ctd4dgE1F8g3uec4zKNRV0&index=10&ab_channel=SebastianLague

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class MapEditor : Editor {
	public override void OnInspectorGUI (){
		//base.OnInspectorGUI ();

		MapGenerator map = target as MapGenerator;
		if (DrawDefaultInspector ()){
		    map.GenerateMap ();
		}
		if (GUILayout.Button("Generate Map")){
            map.GenerateMap ();
		}
	}
}

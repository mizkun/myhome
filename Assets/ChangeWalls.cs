using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWalls : MonoBehaviour {
	private Clicker cliker = new Clicker ();
	public GameObject[] Walls;
	public Material[] WallMaterials;

	int material_index = 0;

	void Start () {
		Walls[0].GetComponent<Renderer> ().material = WallMaterials [material_index];
		Walls[1].GetComponent<Renderer> ().material = WallMaterials [material_index];
	}
	
	void Update () {
		if (cliker.clicked ()) {
			material_index++;
			if (material_index > WallMaterials.Length) {
				material_index = 0;
			}
			Walls [0].GetComponent<Renderer> ().material = WallMaterials [material_index];
			Walls [1].GetComponent<Renderer> ().material = WallMaterials [material_index];
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


	public GameObject Player;
	public GameObject Session1_pos,Session1_UI;
	double distance;
	// Use this for initialization
	void Start () {
		Cursor.visible=false;
		Session1_UI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance (Player.transform.position,Session1_pos.transform.position);
		print (distance);

		if (distance <= 4) {
			Session1_UI.SetActive (true);
			Cursor.visible = true;
		} else {
			Session1_UI.SetActive (false);
			Cursor.visible = false;
		}
	}
}

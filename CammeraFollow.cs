﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CammeraFollow : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		print (player.ToString ());
	}
	
	// lock position 
	void LateUpdate () {
		transform.position = player.transform.position;
	}
}

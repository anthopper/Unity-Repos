using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	[SerializeField] float Xrotation = 1f;
	[SerializeField] float Yrotation = 1f;
	[SerializeField] float Zrotation = 0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float xtransform = Time.deltaTime / 60 * 360 * Xrotation;
		transform.RotateAround (transform.position, transform.up, xtransform);

		float ytransform = Time.deltaTime / 60 * 360 * Yrotation;
		transform.RotateAround (transform.position, transform.right, ytransform);

		float ztransform = Time.deltaTime / 60 * 360 * Zrotation;
		transform.RotateAround (transform.position, transform.forward, ztransform);
	

	}
}

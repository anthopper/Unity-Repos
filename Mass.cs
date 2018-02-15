using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour {

	public static int numMass;
	public bool die;
	public GameObject player;
	public float speed = 1.01f;
	public GameObject Massy;
	GameObject closest;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player");

		numMass++;
		Debug.Log (numMass);
	}
	
	// Update is called once per frame
	void Update () {
		Massy = FindClosestEnemy ();
		//print (Massy);
		Vector3 direction = (Massy.transform.position - transform.position).normalized;
		float distance = (Massy.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;


		if (distance < 1f) {

			die = true;
		}

//		if (die) {
//			numMass--;
//			Destroy (gameObject);
//		}

	}


	GameObject FindClosestEnemy() {
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Mass");

		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			if (go.transform  != transform) {
				Vector3 diff = go.transform.position - position;
				float curDistance = diff.sqrMagnitude;
				if (curDistance + 10 < distance) {
					closest = go;
					distance = curDistance;
				}
			}
		}
		return closest;
	}
}
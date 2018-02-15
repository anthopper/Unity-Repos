using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Enemy.numEnemies < 4) {
			GameObject go = GameObject.CreatePrimitive (PrimitiveType.Capsule);
			go.AddComponent (typeof(Enemy));
			go.transform.position = transform.position;
		}
	}
}

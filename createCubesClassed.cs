using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCubesClassed : createCubes {



	// Use this for initialization
	int numCubes = 100;
	void Start () {
		
		Color col = Color.black;
	
		for (int i = 0; i < numCubes; i++)
		{
			for (int j = 0; j < numCubes; j++) 
			{
				GameObject box = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				box.transform.position = 
					new Vector3 ((i+1) * Random.Range(-2.0f, 2.0f), (j+3) * Random.Range(-3.0f, 3.0f), j * Random.Range(-2.0f, 2.0f));
				box.transform.localScale += new Vector3(2.0F, 0, 2.0f);

				GameObject caps = GameObject.CreatePrimitive (PrimitiveType.Capsule);
				caps.transform.position = 
					new Vector3 ((i+1) * Random.Range(-2.0f, 2.0f), (j+3) * Random.Range(-3.0f, 3.0f), j * Random.Range(-2.0f, 2.0f));
				caps.transform.localScale += new Vector3(2.0F, 0, 2.0f);
				caps.GetComponent<Renderer>().material.color = col;
	}
	}


	}



	//int numCubes = 0;
	// Update is called once per frame
	void Update () {
		GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject go in gos) {
			//go.transform.Rotate (new Vector3 (0, Random.Range(-2.0f, 2.0f), 0f));
			//go.transform.position += Vector3.forward * Time.deltaTime * (Random.Range(0.0f, 2.0f));
			//Debug.Log (go);
		}
//		while (numCubes < 10) 
//		{ GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
//			box.transform.position = new Vector3 (numCubes * 2.0f, 0f, 0f);
//			//box.transform.position = new Vector3 (2.0f + 1f, 0f, 0f);
//			numCubes++;
//		}
	}
}

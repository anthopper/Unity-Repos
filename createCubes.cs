using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCubes : MonoBehaviour {

	// Use this for initialization
	int numCubes = 200;
	void Start () {

		for (int i = 0; i < numCubes; i++)
		{
			for (int j = 0; j < numCubes; j++) 
			{
				GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
				box.transform.position = 
					new Vector3 (i * Random.Range(-2.0f, 2.0f), j * Random.Range(-3.0f, 3.0f), j * Random.Range(-2.0f, 2.0f));
				box.transform.localScale += new Vector3(2.0F, 0, 2.0f);
	}
	}
	}
	//int numCubes = 0;
	// Update is called once per frame
	void Update () {
//		while (numCubes < 10) 
//		{ GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
//			box.transform.position = new Vector3 (numCubes * 2.0f, 0f, 0f);
//			//box.transform.position = new Vector3 (2.0f + 1f, 0f, 0f);
//			numCubes++;
//		}
	}
}

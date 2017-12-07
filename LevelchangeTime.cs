using UnityEngine;
using System.Collections;

public class LevelchangeTime : MonoBehaviour {

	// Use this for initialization
	void Start() {
		StartCoroutine(Example());
	}
	
	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(4);
		Application.LoadLevel(1);
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Vector3 pos;

	void Start () {
		pos = transform.position;
	}

	void Update () {
		bool Wkey = Input.GetKey (KeyCode.W);
		bool Skey = Input.GetKey (KeyCode.S);
		bool Akey = Input.GetKey (KeyCode.A);
		bool Dkey = Input.GetKey (KeyCode.D);
		bool Qkey = Input.GetKey (KeyCode.Q);
		bool Ekey = Input.GetKey (KeyCode.E);
		if (Wkey) {
			pos.y += 0.1f;
		}
		if (Skey) {
			pos.y -= 0.1f;
		}
		if (Akey) {
			pos.x -= 0.1f;
		}
		if (Dkey) {
			pos.x += 0.1f;
		}

		if (Qkey) {
			pos.z += 0.1f;
		}
		if (Ekey) {
			pos.z -= 0.1f;
		}

		gameObject.transform.position = pos;
	}
	}
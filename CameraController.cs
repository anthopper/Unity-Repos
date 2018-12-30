using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //public Camera camera;
    private float x;
    private float y;
    private float z;
    float m_FieldOfView;

    void Start () {
        x = Camera.main.transform.position.x;
        y = Camera.main.transform.position.y;
        z = Camera.main.transform.position.z;
        m_FieldOfView = 60;


    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.U))
        {
            Camera.main.transform.position = new Vector3(x, y++, z);
        }
        if (Input.GetKey(KeyCode.J))
        {
            Camera.main.transform.position = new Vector3(x, y--, z);
        }

        if (Input.GetKey(KeyCode.H))
        {
            Camera.main.fieldOfView = m_FieldOfView++;
        }

        if (Input.GetKey(KeyCode.Y))
        {
            Camera.main.fieldOfView = m_FieldOfView--;
        }
    }
}

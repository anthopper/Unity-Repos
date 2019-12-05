using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoxController : MonoBehaviour
{
    public int speed = 0;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // update player position based on input
        Vector3 position = transform.position;
        position.x += Random.Range(0.0f, 0.1F) * speed * Time.deltaTime;
        position.z += Random.Range(0.0f, .1f) * speed * Time.deltaTime;
        transform.position = position;
    }
}
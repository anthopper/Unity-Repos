using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int strength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            if (Random.Range(0.0f, 50.0f) > strength)
                Debug.Log("bye!");
                Destroy(gameObject);
        }

        if (collision.transform.tag == "Player")
        {
            if (Random.Range(0.0f, 50.0f) > strength)
                Debug.Log("byeme!");
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Random.Range(0.0f, strength) > 10.0f)
                Debug.Log("bye!");
            Destroy(gameObject);
        }

    }

}

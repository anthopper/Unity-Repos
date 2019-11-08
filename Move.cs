using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float m_Speed;
    Rigidbody m_RigidBody;
    bool _jump;

    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        m_Speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_RigidBody.velocity = Vector3.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_RigidBody.velocity = Vector3.left * m_Speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_RigidBody.velocity = Vector3.right * m_Speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_RigidBody.velocity = Vector3.back * m_Speed;
        }


            if (Input.GetKey(KeyCode.Space))
        {
            if (_jump == false)
            {
                _jump = true;
                m_RigidBody.velocity = Vector3.up * (m_Speed * 1.2f);
                StartCoroutine(Waiter());
                
            }
        }


    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(.75f);
        _jump = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveTester : MonoBehaviour
{

    private Vector3 targetPosition;
    public float speed;
    public bool selected;
    private int lastSelected;
    private Ray ray;
    private RaycastHit hit;
    private Renderer cubeRenderer;


    void Start()
    {
        Debug.Log(selected);
        targetPosition = transform.position;
        cubeRenderer = GetComponent<Renderer>();

    }
    // if the mouse is over a gameobject,and themouse is down, select it. 
    //But if it is over a game object, and it is already selected, if clicked, unselect ut
    private void OnMouseOver()
    {
        if (selected == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                selected = true;
                cubeRenderer.material.SetColor("_Color", Color.green);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                selected = false;
                cubeRenderer.material.SetColor("_Color", Color.red);
            }
        }
    }

    void Update()
    {
        // confine movement by speed and time
        float step = speed * Time.deltaTime;

        //checks if we are there yet, if not move us there are rate speed
        if ((Vector3)transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

        //if the ship is selected, set the hit point to the mouse position
            if (selected == true)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
            //if we right click, set the target position to where we click
            if (Input.GetMouseButtonDown(1)) 
            {
                if (Physics.Raycast(ray, out hit))
                {
                    targetPosition = hit.point;
                    //and if we having reached the point yet, deselect the object
                    if ((Vector3)transform.position != targetPosition)
                    {
                        selected = false;
                        cubeRenderer.material.SetColor("_Color", Color.red);
                    }

                }
            }
            }
        



    }
}

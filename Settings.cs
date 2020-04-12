using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public int worldsizeY;
    public int worldsizeX;
    public GameObject terrain;
    
    // Start is called before the first frame update
    void Start()
    {for ( int i = 0; i< worldsizeX; i++)
        {
            Instantiate(terrain, new Vector3(i, 0, 0), Quaternion.identity);
            for ( int j = 0; j < worldsizeY; j++)
            {
                Instantiate(terrain, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

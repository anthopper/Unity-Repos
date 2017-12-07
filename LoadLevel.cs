using System;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class LoadLevel : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);

            }
        }
    
}

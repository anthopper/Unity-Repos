using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


    public class TextEditor : MonoBehaviour
    {


	[SerializeField] public Text txtRef;
	public String Passage;

        private void OnTriggerEnter(Collider other)
        {
		if (other.tag == "Player") {
			txtRef.text = Passage;

		} else 
		{
			txtRef.text = "";
		}
        }
    
}

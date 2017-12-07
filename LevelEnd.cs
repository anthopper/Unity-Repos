using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
	public class LevelEnd : MonoBehaviour
	{
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				SceneManager.LoadScene(SceneManager.GetSceneAt(1).name);
			}
		}
	}
}


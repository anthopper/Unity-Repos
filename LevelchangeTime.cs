using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelchangeTime : MonoBehaviour
{
    public int sceneNumber; //input the number of the scene in the build order.
    public int waitTimebeforeSceneLoad; //how many seconds should we wait before loadingthe scene
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(waitTimebeforeSceneLoad);
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneNumber);
    }



    // Update is called once per frame
    void Update()
    {

    }
}
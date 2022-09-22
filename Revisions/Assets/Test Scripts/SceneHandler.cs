using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SceneHandler : MonoBehaviour
{
 
    public static int newLevel; 

    public void changeLevel(int levelIndex)
    {
        StartCoroutine(ChangeScene(levelIndex));

       newLevel = levelIndex;
    }

    IEnumerator ChangeScene(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject sceneManager;
    public Slider progressBar;
    public Text loadingText;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance = null)
        {
            instance = this;
        }
        sceneManager.SetActive(false);
    }

    public void LoadLevel(int levelIndex)
    {
        Debug.Log($"Level Index + {levelIndex}");
    }

    public void LoadScene(int sceneIndex)
    {
        
        StartCoroutine(LoadSceneAsyncronally(sceneIndex));
        
    }

    IEnumerator LoadSceneAsyncronally(int sceneIndex)
    {
       
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            sceneManager.SetActive(true);
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //MyLogger.Log(operation.progress + "%");
            progressBar.value = progress;
            loadingText.text = progress * 100 + "%";
            yield return null;
        }

    }
}

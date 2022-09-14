using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject sceneManager;
    public Slider progressBar;
    public Text loadingText;

    // Start is called before the first frame update
    void Awake()
    {
        sceneManager.SetActive(false);
    }

    public void LoadLevel(int levelIndex)
    {
        
        StartCoroutine(LoadLevelAsyncronally(levelIndex));
        
    }

    IEnumerator LoadLevelAsyncronally(int levelIndex)
    {
       
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
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

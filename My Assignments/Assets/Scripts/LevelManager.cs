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
        sceneManager.SetActive(true);
        StartCoroutine(LoadLevelAsyncronally(levelIndex));
        MyLogger.Log("LoadLevel() is called");
    }

    IEnumerator LoadLevelAsyncronally(int levelIndex)
    {
       
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f) * 100;
            MyLogger.Log(operation.progress + "%");
            progressBar.value = progress;
            loadingText.text = progress.ToString("F0") + "%";
            yield return null;
        }

    }
}

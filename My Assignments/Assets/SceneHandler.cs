using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour
{
    public static SceneHandler instance;
    public GameObject loadingScreen;
    public Slider progressBar;
    public Text loadingText;
    public int levelIndex;
    private int homeSceneIndex;
    private bool isGameStarted = true;

    void Awake()
    {
        if(instance == this)
        {
            instance = null;
        }
    }

    private void Start()
    {
        homeSceneIndex = 0;
        levelIndex = LevelManager.GAME_PLAY_SCENE_INDEX;
        if(isGameStarted)
        {
            StartCoroutine(LoadSceneCoroutine(homeSceneIndex));
            isGameStarted = false;
        }
        else
        {
            StartCoroutine(LoadSceneCoroutine(levelIndex));
        }
    }
    public IEnumerator LoadSceneCoroutine(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //MyLogger.Log(operation.progress + "%");
            progressBar.value = progress;
            loadingText.text = (progress * 100f).ToString("F0") + "%";
            yield return null;
        }
    }
}

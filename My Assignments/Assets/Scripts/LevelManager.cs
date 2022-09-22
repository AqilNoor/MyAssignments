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
    public static int currentLevelNumber;
    public const int GAME_PLAY_SCENE_INDEX = 1;

    // Start is called before the first frame update
    void Awake()
    {
        sceneManager.SetActive(false);
    }

    public void SetCurrentLevelNumber(int levelNumber)
    {
        currentLevelNumber = levelNumber;
    }

    public void LoadSceneAsync()
    {
        StartCoroutine(LoadSceneCoroutine(GAME_PLAY_SCENE_INDEX));
    }

    IEnumerator LoadSceneCoroutine(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            sceneManager.SetActive(true);
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //MyLogger.Log(operation.progress + "%");
            progressBar.value = progress;
            loadingText.text =( progress * 100).ToString("F0") + "%";
            yield return null;
        }

    }
}

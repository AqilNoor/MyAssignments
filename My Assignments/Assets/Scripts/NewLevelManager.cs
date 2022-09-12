using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewLevelManager : MonoBehaviour
{
    public GameObject sceneManager;
    public Slider progressBar;
    public Text loadingText;

    // Start is called before the first frame update
    void Start()
    {
        sceneManager.SetActive(false);
    }

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(LoadLevelAsyncronally(levelIndex));
    }

    IEnumerator LoadLevelAsyncronally(int levelIndex)
    {
        sceneManager.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            print(operation.progress * 100 + "%");
            progressBar.value = progress;
            loadingText.text = progress * 100 + "%";
            yield return null;
        }

    }
}

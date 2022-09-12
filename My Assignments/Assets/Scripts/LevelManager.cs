using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject progressPanel;
    [SerializeField]
    private Slider progressBar;
    [SerializeField]
    private Text progressText;

    private void Awake()
    {
        progressPanel.SetActive(false);
    }


    public void LoadLevel(string levelName)
    {
        progressPanel.SetActive(true);
        StartCoroutine(LoadLevelAsync(levelName));
    }

    IEnumerator LoadLevelAsync(string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);
        while (!operation.isDone)
        {
            float normalizedProgress = operation.progress/0.9f;
            progressBar.value = normalizedProgress;
            print(normalizedProgress * 100 + "%");
            progressText.text = (normalizedProgress * 100f).ToString("F0") + "%";
            yield return null;
        }
    }
}

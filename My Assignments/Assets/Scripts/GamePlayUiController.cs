using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUiController : MonoBehaviour
{
   
    public GameObject missionPanel;
    
    public GameObject uiControllPanel;
    [SerializeField]
    private GameObject pauselPanel;

    public Text levelIndex;
    public GameObject loadingScenePanel;
    public Text loadingText;
    public Slider progressBar;
    public bool isLevelStarted;

    private void Awake()
    {
        loadingScenePanel.SetActive(false);
        uiControllPanel.SetActive(false);
        pauselPanel.SetActive(false);

        isLevelStarted = true;
        levelIndex.text = LevelManager.currentLevelNumber.ToString();

    }

    void Update()
    {
    }

    public void OpenGameplay()
    {
        if (isLevelStarted)
        {
            uiControllPanel.SetActive(true);
        }
        missionPanel.SetActive(false);
        
        
    }
    public void OpenPausepanel()
    {
            pauselPanel.SetActive(true);
    }

    public void ResumeAndCancel()
    {
        pauselPanel.SetActive(false);
    }

    public void RestartButtonClicked()
    {
        if (pauselPanel == true)
        {
           missionPanel.SetActive(true);
        }
        pauselPanel.SetActive(false);
       uiControllPanel.SetActive(false);
    }



    public void MenuButtonClicked()
    {
        StartCoroutine(BackToHomeScene());
        HomeScreenUI.hasHomeSceneOpenedAlready = true;
    }
     
    IEnumerator BackToHomeScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        while (!operation.isDone)
        {
            loadingScenePanel.SetActive(true);
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            //MyLogger.Log(operation.progress + "%");
            progressBar.value = progress;
            loadingText.text = progress * 100 + "F0" + "%";
            yield return null;
        }
    }

}

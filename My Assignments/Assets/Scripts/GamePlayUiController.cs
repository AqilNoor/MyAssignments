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
    public bool isLevelStarted;

    private void Awake()
    {
        uiControllPanel.SetActive(false);
        pauselPanel.SetActive(false);
        isLevelStarted = true;
        levelIndex.text = LevelManager.currentLevelNumber.ToString();
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
        SceneManager.LoadScene(1);
        HomeScreenUI.hasHomeSceneOpenedAlready = true;
    }
}

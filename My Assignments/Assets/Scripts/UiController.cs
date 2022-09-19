using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]
    private GameObject missionPanel;
    [SerializeField]
    private GameObject uiControllPanel;
    [SerializeField]
    private GameObject pauselPanel;
    public Text levelIndex;
    public bool isLevelStarted;

    private void Awake()
    {
        uiControllPanel.SetActive(false);
        pauselPanel.SetActive(false);
        isLevelStarted = true;
        levelIndex.text = CampaignLevelHandler.levelsUnlocked.ToString();

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
        isLevelStarted = false;
    }

    public void OpenPausepanel()
    {
        if (!isLevelStarted && uiControllPanel == true)
        {
            pauselPanel.SetActive(true);
        }

        isLevelStarted = true;
    }

    public void Resume()
    {
        if (isLevelStarted && pauselPanel == true)
        {
            pauselPanel.SetActive(false);
        }

        isLevelStarted = false;
    }

    public void MenuButtonClicked()
    {
       SceneManager.LoadSceneAsync(0);
    }

}

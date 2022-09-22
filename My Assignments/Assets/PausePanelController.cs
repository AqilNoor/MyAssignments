using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanelController : MonoBehaviour
{
    [SerializeField]
    private GameObject pauselPanel;
    private GamePlayUiController gamePlayUiController;
   
    void Start()
    {
        gamePlayUiController = GetComponent<GamePlayUiController>();
        pauselPanel.SetActive(false);
    }

     public void OpenPausepanel()
    {
        
        {
            pauselPanel.SetActive(true);
        }

      
    }

    public void ResumeAndCancel()
    {
        if ( pauselPanel == true)
        {
            pauselPanel.SetActive(false);
        }

        
    }

    public void RestartButtonClicked()
    {
        if (pauselPanel == true)
        {
          gamePlayUiController.missionPanel.SetActive(true);
        }
        pauselPanel.SetActive(false);
        gamePlayUiController.uiControllPanel.SetActive(false);
    }
}

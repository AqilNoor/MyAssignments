using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CampaignLevelHandler : MonoBehaviour
{
    public GameObject[] levelUnlocked;
    public GameObject[] levelLocked;
    public GameObject[] rotatingImage;

    private bool levelPassed;
    
    public void CallLevel(int levelNum)
    {
        int levelNumber = levelNum;
         
        switch (levelNumber)
        {
            case 2:
                levelUnlocked[0].SetActive(true);
                levelLocked[0].SetActive(false);
                rotatingImage[0].SetActive(true);
                break;
            case 3:
                levelUnlocked[1].SetActive(true);
                levelLocked[1].SetActive(false);
                rotatingImage[1].SetActive(true);
                break;
            case 4:
                levelUnlocked[2].SetActive(true);
                levelLocked[2].SetActive(false);
                rotatingImage[2].SetActive(true);
                break;
            case 5:
                levelUnlocked[3].SetActive(true);
                levelLocked[3].SetActive(false);
                rotatingImage[3].SetActive(true);
                break;
            case 6:
                levelUnlocked[4].SetActive(true);
                levelLocked[4].SetActive(false);
                rotatingImage[4].SetActive(true);
                break;
            case 7:
                levelUnlocked[5].SetActive(true);
                levelLocked[5].SetActive(false);
                rotatingImage[5].SetActive(true);
                break;
            case 8:
                levelUnlocked[6].SetActive(true);
                levelLocked[6].SetActive(false);
                rotatingImage[6].SetActive(true);
                break;
            case 9:
                levelUnlocked[7].SetActive(true);
                levelLocked[7].SetActive(false);
                rotatingImage[7].SetActive(true);
                break;
            case 10:
                levelUnlocked[8].SetActive(true);
                levelLocked[8].SetActive(false);
                rotatingImage[8].SetActive(true);
                break;
        }
        
    }





}

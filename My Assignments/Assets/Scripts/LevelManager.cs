using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static int currentLevelNumber;
    public static int GAME_PLAY_SCENE_INDEX =1;

    public void SetCurrentLevelNumber(int levelNumber)
    {
        currentLevelNumber = levelNumber;
    }

    public void LoadSceneAsync()
    {
        SceneManager.LoadScene(GAME_PLAY_SCENE_INDEX);
    }

    public void BackToManu()
    {
        SceneManager.LoadScene(GAME_PLAY_SCENE_INDEX);
    }

}

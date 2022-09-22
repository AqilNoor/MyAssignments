using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    public Text textOnScreen;

    public void Start()
    {
        textOnScreen.text = SceneHandler.newLevel.ToString();
    }
  
}

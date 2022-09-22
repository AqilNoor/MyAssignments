using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    int score = 10,
    score2 = 20;
    float speed = 8.5f;

    void Start()
    {
        print($"The Value of Score is : {score} and Speed = {speed} of Player ");
        print("Start Method is called");
    }

    private void OnEnable()
    {
        print("Inside OnEnable");

    }

    private void OnDisable()
    {
        print("Inside OnDisable");
    }
}

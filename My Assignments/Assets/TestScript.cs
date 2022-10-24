using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public static int speed = 10;
    public  int newSpeed = 20;
    public int currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        print($"At first Stage Current Speed is: {currentSpeed}");
        currentSpeed = newSpeed;
        print($"After some time the Current Speed is:{currentSpeed}");
    }
}

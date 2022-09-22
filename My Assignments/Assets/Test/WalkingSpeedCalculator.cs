using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSpeedCalculator 
{
    public static void CalculateWalkinSpeed(Human human)
    {
        Debug.Log("Calculating walkingSpeed");
        human.walkingSpeed = 20f;
    }
}

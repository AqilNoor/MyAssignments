using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightCalculator
{
    public static void CalculateHeight(Human human)
    {
        Debug.Log("Calculating height");
        human.height = 60f;
    }
}

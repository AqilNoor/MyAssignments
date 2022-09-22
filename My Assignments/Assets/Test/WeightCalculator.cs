using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCalculator
{ 
    public static void CalculateWeight(Human human)
    {
        Debug.Log("Calculating weight");
        human.weight = 80f;
    }
}

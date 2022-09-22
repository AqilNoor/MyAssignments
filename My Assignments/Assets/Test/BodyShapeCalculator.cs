using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyShapeCalculator
{
    public static void CalculateBodyShape(Human human)
    {
        Debug.Log("Calculating BodyShape");
        human.bodyShape = Human.BodyShape.NORMAL;
        
    }
}

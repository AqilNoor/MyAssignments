using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinColorCalculator
{
    public static void CalculateSkinColor(Human human)
    {
        Debug.Log("Calculating skinColor");
        human.skinColor = new Color(4f,5f,3f);
    }
}

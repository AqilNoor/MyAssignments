using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePitchCalculator
{
    public static void CalculateVoicePitch(Human human)
    {
        Debug.Log("Calculating voicePitch");
        human.voicePitch = 5f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HumanBuilder
{
    public static Human BuildNewHuman()
    {
        var human = new Human();

        WeightCalculator.CalculateWeight(human);
        HeightCalculator.CalculateHeight(human);
        WalkingSpeedCalculator.CalculateWalkinSpeed(human);
        VoicePitchCalculator.CalculateVoicePitch(human);
        SkinColorCalculator.CalculateSkinColor(human);
        BodyShapeCalculator.CalculateBodyShape(human);
        return human;
    }
}

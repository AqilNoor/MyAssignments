using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human
{
    public enum BodyShape { SLIM, NORMAL, FAT }

    public float weight;
    public float height;
    public float walkingSpeed;
    public float voicePitch;
    public Color skinColor;
    public BodyShape bodyShape;
}
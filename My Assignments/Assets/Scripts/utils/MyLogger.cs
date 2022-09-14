using UnityEngine;
public class MyLogger
{
    public static bool show = true;
    public static void Log(string msg)
    {
        if (show)
            Debug.Log(msg);
    }

    public static void LogWarning(string msg)
    {
        if (show)
            Debug.LogWarning(msg);
    }

    public static void LogEror(string msg)
    {
        if (show)
            Debug.LogError(msg);
    }
}
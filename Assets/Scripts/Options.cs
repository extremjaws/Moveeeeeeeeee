using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Options
{
    public static float Sens = 2;
    public static float fov = 90;
    public static bool gamermode = true;
    public static int timer = 0;
    public static float time = 0;
    public static int mode = 0;
    public static List<int> LevelTypes = new List<int> { };
    public static List<Vector3> LevelVecs = new List<Vector3> { };
    public static string LeftOff = "Level 1";
}

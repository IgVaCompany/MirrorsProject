using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Params : MonoBehaviour
{
    public static bool visib = false;
    public static bool work = false;
    public static bool workLaser = false;
    public static bool flagB1 = false;
    public static bool flagB2 = false;
    public static bool flagB3 = false;
    public static bool laserOn = false;
    public static bool fromfile = false;

    public static  List<GameObject> mirrorsList = new List<GameObject>();

    public static GameObject[] Mirrors;
    public static List<double> X1  = new List<double>();
    public static List<double> Y1  = new List<double>();
    public static List<double> X2 = new List<double>();
    public static List<double> Y2 = new List<double>();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAll : MonoBehaviour {

    public static void FuncClearALL()
    {
        Params.visib = false;
        Params.work = false;
        Params.workLaser = false;
        Params.flagB1 = false;
        Params.flagB2 = false;
        Params.flagB3 = false;
        Params.laserOn = false;

        Params.X1.Clear();
        Params.Y1.Clear();
        Params.X2.Clear();
        Params.Y2.Clear();

        Params.Mirrors = GameObject.FindGameObjectsWithTag("Mirror");
        for (int i = 0; i < Params.Mirrors.Length; i++)
        {
            Destroy(Params.Mirrors[i]);
        }  
            
        Debug.Log("ClearAll OK!");
    }
}

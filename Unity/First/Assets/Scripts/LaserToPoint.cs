using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LaserToPoint : MonoBehaviour
{

    private static  GameObject LaserObj;

    public static void LaserToCoord()
    {
        Params.laserX1 = 0;
        Params.laserX2 = 0;
        Params.laserY1 = 0;
        Params.laserY2 = 0;


        LaserObj = GameObject.FindGameObjectWithTag("Laser");

        if (LaserObj == null)
        {
            Debug.Log("No Laser Set");
        }
        else
        {
            Params.laserX1 = LaserObj.transform.position.x +
                             1.75f*LaserObj.transform.lossyScale.x*Math.Cos(LaserObj.transform.rotation.z*(Math.PI/180));
            Params.laserX2 = LaserObj.transform.position.y +
                             1.75f*LaserObj.transform.lossyScale.x*Math.Sin(LaserObj.transform.rotation.z*(Math.PI/180));
            Params.laserY1 = LaserObj.transform.position.x -
                             1.75f*LaserObj.transform.lossyScale.x*Math.Cos(LaserObj.transform.rotation.z*(Math.PI/180));
            Params.laserY2 = LaserObj.transform.position.y -
                             1.75f*LaserObj.transform.lossyScale.x*Math.Sin(LaserObj.transform.rotation.z*(Math.PI/180));

            Debug.Log(Params.laserX1 + " " + Params.laserY1);
            Debug.Log(Params.laserX2 + " " + Params.laserY2);
        }


    }
}

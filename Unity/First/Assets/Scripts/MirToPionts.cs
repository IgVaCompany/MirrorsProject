using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirToPionts : MonoBehaviour {
    //public static GameObject[] Mirrors;

    public static void MirToCoord()
    {
        if (Params.Mirrors == null)
            Params.Mirrors = GameObject.FindGameObjectsWithTag("Mirror");

        foreach (var mir in Params.Mirrors)
        {
            Params.X1.Add(mir.transform.position.x + 3.5f * mir.transform.lossyScale.x * Math.Cos(mir.transform.rotation.z * (Math.PI/180))); 
            Params.Y1.Add(mir.transform.position.x + 3.5f * mir.transform.lossyScale.x * Math.Sin(mir.transform.rotation.z * (Math.PI / 180)))
            ;
        }

        for (int i = 0; i < Params.X1.ToArray().Length; i++)
        {
            Debug.Log(Params.X1.ToArray()[i] + " " + Params.Y1.ToArray()[i]);
        }
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

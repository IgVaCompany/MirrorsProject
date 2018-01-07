using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirToPionts : MonoBehaviour {
  

    public static void MirToCoord()
    {

        Params.X1.Clear();
        Params.Y1.Clear();
        Params.X2.Clear();
        Params.Y2.Clear();

        if (Params.Mirrors == null)
            Params.Mirrors = GameObject.FindGameObjectsWithTag("Mirror");

        foreach (var mir in Params.Mirrors)
        {           
            Params.X1.Add(mir.transform.position.x + 1.75f * mir.transform.lossyScale.x * Math.Cos(mir.transform.rotation.z * (Math.PI / 180))); 
            Params.Y1.Add(mir.transform.position.y + 1.75f * mir.transform.lossyScale.x * Math.Sin(mir.transform.rotation.z * (Math.PI / 180)));
            Params.X2.Add(mir.transform.position.x - 1.75f * mir.transform.lossyScale.x * Math.Cos(mir.transform.rotation.z * (Math.PI / 180)));
            Params.Y2.Add(mir.transform.position.y - 1.75f * mir.transform.lossyScale.x * Math.Sin(mir.transform.rotation.z * (Math.PI / 180)));
        }

        foreach (var mir in Params.Mirrors)
        {
            Debug.Log(mir.transform.position.x + " "+ mir.transform.position.y);
        }
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

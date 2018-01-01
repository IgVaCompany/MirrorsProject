using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMov : MonoBehaviour
{
    private bool mouseDown = false;


    void OnMouseDown()
    {
        mouseDown = true;
    }

    void OnMouseUp()
    {
        mouseDown = false;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	Vector3 cursor = Camera.main.ScreenToWorldPoint()
	}
}

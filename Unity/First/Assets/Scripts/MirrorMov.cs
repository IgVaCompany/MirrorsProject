using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMov : MonoBehaviour
{
    bool mouseDown = false;
    Vector3 cursor =new Vector3();

    void OnMouseDown()
    {
        mouseDown = true;
        Debug.Log("OnMouseDown is completed");
    }

    void OnMouseUp()
    {
        mouseDown = false;
        Debug.Log("OnMouseUp is completed");
        
    }

    void OnMouseDrag()
    {
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.Euler(cursor);

        //cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //cursor.z = 0;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    this.transform.position = cursor;
        //}
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
      
	    //Vector3 cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	    //cursor.z = 0;
	    //if (Input.GetMouseButtonDown(0))
	    //{
	    //    this.transform.position = cursor;
	    //}
	}
}

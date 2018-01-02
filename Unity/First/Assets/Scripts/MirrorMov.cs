 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMov : MonoBehaviour
{
    bool mouseDown = false;
    private Color basicColor = Color.white;
    private Color hoverColor = Color.red;
    private Renderer ren;
    private float speed = 10f;
    private float speedAdd = 20f;
    Vector3 cursor =new Vector3();
    private bool scaleXplus = false;
    private bool scaleXnegativ = false;

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

    void OnMouseEnter()
    {
        ren.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        ren.material.color = basicColor;
    }
    void OnMouseDrag()
    {
        Params.work = true;
        ren = GetComponent<Renderer>();
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursor.z = 0;
      //  ren.material.color = new Color(1,0,0);        
        this.transform.position = cursor;      

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(new Vector3(0,0,(speed)*Time.deltaTime));
           // new Quaternion();
        } 
               
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Rotate(new Vector3(0, 0, (-speed) * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("w");
            scaleXplus = true;                          
        }
        else
        {
            scaleXplus = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("s");
            scaleXnegativ = true;
        }
        else
        {
            scaleXnegativ = false;
        }
    }


    
    // Use this for initialization
    void Start () {
        ren = GetComponent<Renderer>();
        ren.material.color = basicColor;
    }
	
	// Update is called once per frame
	void Update ()
	{	               
    }

    void FixedUpdate()
    {
        Vector3 scal = transform.localScale;
        //Debug.Log(scal);
        if (scaleXplus && scal.x<100)                 
            transform.localScale = new Vector3(scal.x+0.5f, scal.y, scal.z);
        

        if (scaleXnegativ && scal.x>5)          
            transform.localScale = new Vector3(scal.x - 0.5f, scal.y, scal.z);
       



    }
}

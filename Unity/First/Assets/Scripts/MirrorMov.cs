using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMov : MonoBehaviour
{
    bool mouseDown = false;
    private Renderer ren;
    private float speed = 10f;
    private float speedAdd = 20f;
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

    void OnMouseExit()
    {
        ren.material.color = new Color(255,255,255);
    }
    void OnMouseDrag()
    {
        ren = GetComponent<Renderer>();
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursor.z = 0;
        ren.material.color = new Color(1,0,0);        
        this.transform.position = cursor;      

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(new Vector3(0,0,(speed)*Time.deltaTime));
            new Quaternion();
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }


    }

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
      	   
	}
}

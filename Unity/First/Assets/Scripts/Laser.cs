using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    private Color basicColor = Color.yellow;
    private Color hoverColor = Color.green;
    private Renderer ren;
    private Vector3 cursor = new Vector3();
    private float speed = 10f;

    private void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = basicColor;
    }

    private void OnMouseEnter()
    {
        Params.workLaser = true;
        ren.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        ren.material.color = basicColor;
        Params.workLaser = false;
    }

    private void OnMouseDrag()
    {

        ren = GetComponent<Renderer>();
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursor.z = 0;
        //  ren.material.color = new Color(1,0,0);        
        this.transform.position = cursor;

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(new Vector3(0, 0, (speed)*Time.deltaTime));
            // new Quaternion();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Rotate(new Vector3(0, 0, (-speed)*Time.deltaTime));
        }
    }
}

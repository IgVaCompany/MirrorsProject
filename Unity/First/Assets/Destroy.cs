using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroy : MonoBehaviour
{
    public GameObject Laser;
    private Button but;

    void Start()
    {
        but = Laser.GetComponent<Button>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            but.interactable = true;
            Params.laserOn = false;
            Params.workLaser = false;
            Params.flagB2 = false;
        }
          

        Debug.Log("Enter");     
        Destroy(other.gameObject);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

    
    void OnTriggerEnter(Collider other)
    {
       
        Debug.Log("Enter");
        //   Destroy(other.gameObject);
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
        //   Destroy(other.gameObject);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        //   Destroy(other.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{


    public GameObject objects;

	// Use this for initialization
	void Start ()
	{
        
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Params.visib)
	    {
            objects.transform.parent = GameObject.Find("Canvas").transform;
            Instantiate(objects, objects.transform.position, Quaternion.identity);
        }
    }
}

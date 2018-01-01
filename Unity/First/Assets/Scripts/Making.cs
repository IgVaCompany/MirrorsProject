using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Making : MonoBehaviour {
    public GameObject objectss;
    public Vector3 mosPos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Params.work && Input.GetMouseButtonUp(0))
	    {


	        mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Instantiate(objectss, new Vector3(mosPos.x, mosPos.y, 0), Quaternion.identity);
                    
            Debug.Log(mosPos);
        }
		
	}
}

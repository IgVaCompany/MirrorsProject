using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Making : MonoBehaviour {

    public GameObject objectsB1;
    public GameObject objectsB2;
    public GameObject objectsB3;

   public  Vector3 mosPos;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonUp(0) && Params.flagB1)
	    {
            Debug.Log("Hello");
            float rand1 = Random.Range(-50, 50);
            float rand2 = Random.Range(-50, 50);
            Instantiate(objectsB1, new Vector3(rand1, rand2, 0), Quaternion.identity);
        } else if (Input.GetMouseButtonUp(0) && Params.flagB2)
        {
            mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectsB2, new Vector3(mosPos.x, mosPos.y, 0), Quaternion.identity);
            Debug.Log(mosPos);
        }
        else if (Input.GetMouseButtonUp(0) && Params.flagB3)
        {
            mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectsB3, new Vector3(mosPos.x, mosPos.y, 0), Quaternion.identity);
            Debug.Log(mosPos);
        }
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PushButton : MonoBehaviour {

    public  GameObject objects;

    public void Click()
    {
        Debug.Log("Hello");
        float rand1 = Random.Range(-50,50);
        float rand2 = Random.Range(-50, 50);
        Instantiate(objects, new Vector3(rand1,rand2,0), Quaternion.identity);
        Params.work = false;
    }

    public void MousePos()
    {
        
            if (Input.GetMouseButtonUp(0))
            {
                float x = Input.mousePosition.x;
                float y = Input.mousePosition.y;

                Debug.Log(x);
                Debug.Log(y);
                Params.work = true;               
            }
       
        
    }
}

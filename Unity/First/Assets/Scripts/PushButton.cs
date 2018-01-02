using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PushButton : MonoBehaviour {
   
    public void ClickB1()
    {       
        Params.flagB1 = true;
        Params.flagB2 = false;
        Params.flagB3 = false;
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

    public void ClickB2()
    {
        Params.flagB1 = false;
        Params.flagB2 = true;
        Params.flagB3 = false;
    }

    public void ClickB3()
    {
        Params.flagB1 = false;
        Params.flagB2 = false;
        Params.flagB3 = true;
        Params.work = false;
       

    }

    

}

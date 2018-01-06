using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PushButton : MonoBehaviour
{

    public GameObject mirror;
    public GameObject laser;


    public void ClickB2()
    {
        Params.flagB1 = false;
        Params.flagB2 = true;
        Params.flagB3 = false;
        Params.work = false;
        laser.SetActive(true);
        mirror.SetActive(false);
    }

    public void ClickB3()
    {
        Params.flagB1 = false;
        Params.flagB2 = false;
        Params.flagB3 = true;
        Params.work = false;
        laser.SetActive(false);
        mirror.SetActive(true);
    }

    public void PrepeirToCalc()
    {
        MirToPionts.MirToCoord();
    }

    public void Quit()
    {
        Application.Quit();
    }
    

}

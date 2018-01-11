using System.Collections;
using System.Collections.Generic;
using System.IO;
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

    public void SaveToFile()
    {

        MirToPionts.MirToCoord();
        StreamWriter sw = new StreamWriter("name.txt");
        sw.WriteLine("X1\t\t\tY1\t\t\tX2\t\t\tY2");
        for (int i = 0; i < Params.Y2.ToArray().Length; i++)
        {
            sw.WriteLine(Params.X1.ToArray()[i] + "\t" + Params.Y1.ToArray()[i] + "\t" + Params.X2.ToArray()[i] + "\t" + Params.Y2.ToArray()[i]);
        }
        sw.Close();
    }

    public void DLFF()
    {
        FromFile.DataFromFile();
        Params.fromfile = true;
    }

    public void PrepeirToCalc()
    {
        LaserToPoint.LaserToCoord();
        MirToPionts.MirToCoord();
    }

    public void ClearAllBtn()
    {
        ClearAll.FuncClearALL();
    }

    public void Quit()
    {
        Application.Quit();
    }
    

}

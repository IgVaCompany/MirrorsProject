using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FromFile : MonoBehaviour
{
    
    public  GameObject MirrorObj;
    public GameObject LaserObj;


    private static string NameFile;
    private static  string[] DataFile;
    private static string[] valueNames = {"X1","Y1","X2","Y2"};
    private static string mines = "-";
    private static bool bild = false;
    private static float size,scaleSize;
    static  Vector3 pos = new Vector3();
    static Vector3 scaleV = new Vector3();
    static Vector3 angels = new Vector3(0,0,1);
    private static float angle;

    public static void DataFromFile()
    {

            ClearAll.FuncClearALL();
            NameFile = "name.txt";
            DataFile = File.ReadAllLines(NameFile);
            Debug.Log(DataFile[0]);

            for (int i = 1; i < DataFile.Length; i++)
            {

                String value = DataFile[i];
                String[] vaslues = value.Split(new char[] {'\t', ' ', '|', '[', ']'},
                    StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < vaslues.Length; j++)
                {
                    switch (valueNames[j])
                    {
                        case "X1":
                            if (valueNames[j].Contains(mines))
                                Params.X1.Add(-1*Convert.ToDouble(vaslues[j]));
                            else
                                Params.X1.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "Y1":
                            if (valueNames[j].Contains(mines))
                                Params.Y1.Add(-1*Convert.ToDouble(vaslues[j]));
                            else
                                Params.Y1.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "X2":
                            if (valueNames[j].Contains(mines))
                                Params.X2.Add(-1*Convert.ToDouble(vaslues[j]));
                            else
                                Params.X2.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "Y2":
                            if (valueNames[j].Contains(mines))
                                Params.Y2.Add(-1*Convert.ToDouble(vaslues[j]));
                            else
                                Params.Y2.Add(Convert.ToDouble(vaslues[j]));
                            break;
                    }
                }
            }
            // Debug.Log(Params.X1.ToArray()[0] + " " + (Params.Y1.ToArray()[0]) + " " + Params.X2.ToArray()[0] +" "+ (Params.Y2.ToArray()[0]));
            bild = true;


    }

 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (bild)
	    {
            for (int i = 0; i < Params.X1.ToArray().Length; i++)
            {
                pos.x = Convert.ToSingle((Params.X1.ToArray()[i] + Params.X2.ToArray()[i]) / 2);
                pos.y = Convert.ToSingle((Params.Y1.ToArray()[i] + Params.Y2.ToArray()[i]) / 2);
                pos.z = 0;
                size = Convert.ToSingle(Math.Sqrt((Params.X2.ToArray()[i]-Params.X1.ToArray()[i]) * (Params.X2.ToArray()[i] - Params.X1.ToArray()[i]) + (Params.Y2.ToArray()[i] - Params.Y1.ToArray()[i]) * (Params.Y2.ToArray()[i]-Params.Y1.ToArray()[i])));
                scaleV.x = size /3.5f;
                scaleV.y = 1;
                scaleV.z = 1;
                angle = Convert.ToSingle((Math.PI / 180) * Math.Asin((Params.Y1.ToArray()[i]-pos.y)/(size/2)));

                Debug.Log(pos.x + " " + pos.y);
                Instantiate(MirrorObj, pos, Quaternion.AngleAxis(angle,angels));

             
                if (i+1  == Params.X1.ToArray().Length)
                    bild = false;
            }
        }
		
	}
}

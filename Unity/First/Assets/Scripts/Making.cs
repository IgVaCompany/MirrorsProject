using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Making : MonoBehaviour {

    public GameObject objectsB1;
    public GameObject objectsB2;
    public GameObject objectsB3;
    public GameObject PutLaser;
    public GameObject Mirrortxt;
    public GameObject Lasertxt;
    private Button but;

   public  Vector3 mosPos;

  
    // Use this for initialization
    void Start ()
    {
        
        but = PutLaser.GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && Params.flagB2 && !Params.workLaser && !Params.laserOn)
        {
            mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectsB2, new Vector3(mosPos.x, mosPos.y, 0), Quaternion.identity);
            Debug.Log("LaserFix");
            Params.laserOn = true;
            but.interactable = false;
            Lasertxt.SetActive(false);

        }
        else if (Input.GetMouseButtonDown(0) && Params.flagB3 && !Params.work)
        {
            mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectsB3, new Vector3(mosPos.x, mosPos.y, 0), Quaternion.identity);
            Params.mirrorsList.Add(this.gameObject);
            Debug.Log(Params.mirrorsList.ToArray().Length);
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Params.flagB1 = false;
            Params.flagB2 = false;
            Params.flagB3 = false;
            Mirrortxt.SetActive(false);
            Lasertxt.SetActive(false);
        }

    }
}

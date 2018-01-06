using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCorrect : MonoBehaviour {

    private Button but;

    // Use this for initialization
    void Start () {
        but = GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    but.interactable = false;
	}
}

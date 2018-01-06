using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnyShow : MonoBehaviour
{

    public GameObject ON;
    public GameObject OFF;


    private void OnMouseEnter()
    {
        ON.SetActive(true);
        OFF.SetActive(false);
    }

    private void OnMouseExit()
    {
        ON.SetActive(false);
        OFF.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public bool go = false;
    public bool direct = false;
    private SpriteRenderer ren;
    private Animator anim;

	// Use this for initialization
	void Start ()
	{

	    ren = GetComponent<SpriteRenderer>();
	    ren.flipX = direct;
	    anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{	  
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            go = true;
            direct = false;
            //  anim.GetParameter();
            //ren.flipX = false;
            ren.flipX = direct;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            go = true;
            direct = true;
            // ren.flipX = true;
            ren.flipX = direct;
        }
    }
}

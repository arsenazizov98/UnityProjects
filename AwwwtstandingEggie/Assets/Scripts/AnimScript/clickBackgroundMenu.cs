using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBackgroundMenu : MonoBehaviour {

    private Animator animator = null;
    public static bool isFirstClick = true;
    public bool b = isFirstClick;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void OnMouseDown()
    {
        if (isFirstClick)
        {
            animator.SetBool("up", false);
            animator.SetBool("down", true);
        }
    }

    public void OnMouseUp()
    {
        animator.SetBool("up", true);
        animator.SetBool("down", false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}

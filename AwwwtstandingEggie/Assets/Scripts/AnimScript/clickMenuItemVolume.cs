using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickMenuItemVolume : MonoBehaviour {

    private Animator animator = null;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void touchDown()
    {
        animator.SetBool("down", true);
    }

    public void touchUp()
    {
        
    }

    public void setSound(int isSound)
    {
        animator.SetBool("down", false);
        if (isSound==1)
            animator.SetBool("isSound", true);
        else
            animator.SetBool("isSound", false);
    }

    public void setMusic(int isMusic)
    {
        animator.SetBool("down", false);
        if (isMusic == 1)
            animator.SetBool("isMusic", true);
        else
            animator.SetBool("isMusic", false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

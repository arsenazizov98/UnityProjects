using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickMenuItem : MonoBehaviour {

    public string nameTransferScene = null;
    private Animator animator = null;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}


    public void touchDown()
    {
        clickBackgroundMenu.isFirstClick = false;
        animator.SetBool("up", false);
        animator.SetBool("down", true);
    }

    public void touchUp()
    {
        animator.SetBool("up", true);
        animator.SetBool("down", false);
        clickBackgroundMenu.isFirstClick = true;
    }

    public void transfer()
    {
        SceneManager.LoadScene(nameTransferScene);

    }

    // Update is called once per frame
    void Update () {
        
	}
}

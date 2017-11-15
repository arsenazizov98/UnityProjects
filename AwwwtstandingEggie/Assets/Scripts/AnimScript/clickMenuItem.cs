using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickMenuItem : MonoBehaviour {

    public GameObject animCollider = null;
    private Animator animator = null;
    public string nameTransferScene = null;
    public string animationName = null;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}


    public void touchDown()
    {
        animator.SetBool("up", false);
        animator.SetBool("down", true);
    }

    public void touchUp()
    {
        animator.SetBool("up", true);
        animator.SetBool("down", false);
    }

    public void transfer()
    {
        SceneManager.LoadScene(nameTransferScene);

    }

    // Update is called once per frame
    void Update () {
        
	}
}

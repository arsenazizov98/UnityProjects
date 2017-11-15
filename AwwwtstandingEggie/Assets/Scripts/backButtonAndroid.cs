using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButtonAndroid : MonoBehaviour {

    public string backScene;

	// Use this for initialization
	void Start () {
		
	}

    public void touchDown()
    {

    }

    public void touchUp()
    {
        if (backScene == null)
            Application.Quit();
        else
            SceneManager.LoadScene(backScene);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (backScene == null)
                Application.Quit();
            else
                SceneManager.LoadScene(backScene);
    }
}

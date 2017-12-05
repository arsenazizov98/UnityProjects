using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodenSunClick : MonoBehaviour {

    public ConstantForce2D constForce = null;
    public float force = 40f;
	// Use this for initialization
	void Start () {
		
	}


    public void OnMouseDown()
    {
        constForce.force = new Vector2(force, 0);
    }

    public void OnMouseUp()
    {
        constForce.force = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

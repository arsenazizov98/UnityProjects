using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour {

    public bool clickedIs = false;
    

    
    public void onClick()
    {
        clickedIs = true;
    }

    public void onStopClick()
    {
        clickedIs = false;
    }
}

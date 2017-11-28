using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMotion : MonoBehaviour {

    // точки, между которыми бот будет двигаться, в ожидании игрока
    public float distanceA;
    public float distanceB;

    public float speed = 1.5f; // скорость движения
    public float acceleration = 10; // ускорение

    private int layerMask;
    private bool isTarget, isWait;
    public RectTransform rectTransform;
    private Vector3 direction;
    private float curDist;

    Vector3 SetDirection(float xPos)
    {
        return new Vector3(xPos, transform.position.y, transform.position.z) - transform.position;
    }

    void Start()
    {
    }

    // float a = rectTransform.position.x - distanceA;
    // float b = rectTransform.position.x - distanceB;
    bool isA = false;
    bool isB = false;
    void Update()
    {
        if (!isA) {
            rectTransform.position = new Vector3(rectTransform.position.x + speed, rectTransform.position.y, rectTransform.position.z);
            if (rectTransform.position.x > distanceA)
            {
                isA = true;
                isB = false;
            }
        }
        else if(!isB){
            rectTransform.position = new Vector3(rectTransform.position.x - speed, rectTransform.position.y, rectTransform.position.z);
            if (rectTransform.position.x < distanceB)
            {
                isB = true;
                isA = false;
            }
        }
    }

}

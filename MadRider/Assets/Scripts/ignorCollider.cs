using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignorCollider : MonoBehaviour {

    public GameObject ignorLayer;
    public GameObject ignorLayer2;
    void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 9);//ignorLayer2.GetComponent<Collider2D>()
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class switchRagdoll : MonoBehaviour {
    public CircleCollider2D gob;
    public int i = 0;
    void OnCollisionStay2D(Collision2D coll)
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        ((BoxCollider2D)coll.gameObject.GetComponent("BoxCollider2D")).enabled = false;
        ((Rigidbody2D)coll.gameObject.GetComponent("Rigidbody2D")).simulated = false;
        //((SpriteRenderer)coll.gameObject.GetComponent("SpriteRenderer")).enabled = false;
        SpriteRenderer[] spr = coll.gameObject.GetComponentsInChildren<SpriteRenderer>();
        PolygonCollider2D[] pol = coll.gameObject.GetComponentsInChildren<PolygonCollider2D>();
        for (int n=pol.Length; i < n; i++ )
        {
                spr[i].enabled = true;
                pol[i].enabled = true;
        }
        //coll.gameObject.GetComponent<Rigidbody2D>().simulated = false;
        //coll.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //gob.enabled = true;        
    }
}

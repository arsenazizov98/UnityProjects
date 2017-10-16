using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchRagdoll : MonoBehaviour {
    public CircleCollider2D gob;
    void OnCollisionStay2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        coll.gameObject.GetComponent<Rigidbody2D>().simulated = false;
        PolygonCollider2D[] pol = coll.gameObject.GetComponentsInChildren<PolygonCollider2D>();
        Rigidbody2D[] rig = coll.gameObject.GetComponentsInChildren<Rigidbody2D>();
        for (int i = 0, n = pol.Length; i < n; i++)
        {
            pol[i].enabled = true;
            rig[i].simulated = true;
        }
        gob.enabled = true;
    }
}

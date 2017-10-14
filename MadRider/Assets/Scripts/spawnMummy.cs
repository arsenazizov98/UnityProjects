using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMummy : MonoBehaviour {

    public GameObject enemy;
    public SpriteRenderer[] parts;
    public int count = 15;
    public int length = 0;
    /*public GameObject head;
    public GameObject bodyTop;
    public GameObject bodyBot;
    public GameObject armTopIn;
    public GameObject armBotIn;
    public GameObject handIn;
    public GameObject armTopOut;
    public GameObject armBotOut;
    public GameObject handOut;
    public GameObject legTopIn;
    public GameObject legBotIn;
    public GameObject footIn;
    public GameObject legTopOut;
    public GameObject legBotOut;
    public GameObject footOut;*/

    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0f;

	// Use this for initialization
	void Start () {
        for (int j = 0; j < 10; j++)
        {
            randX = Random.Range(-50f, 100f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            parts = Instantiate(enemy, whereToSpawn, Quaternion.identity).GetComponentsInChildren<SpriteRenderer>();
            length = parts.Length;
            for (int i = 0, n = parts.Length; i < n; i++)
            {
                parts[i].sortingOrder += count;
            }
            count += 15;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
        
	}
}

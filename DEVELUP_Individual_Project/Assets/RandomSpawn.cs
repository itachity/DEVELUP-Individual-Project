using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject coin;

    public float spawnRate = 1f;

    float nextSpawn = 0f;

    
	// Use this for initialization
	void Start () {
        nextSpawn = 0f;
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 pos = new Vector2(Random.Range(-8, 10),8);

        Debug.Log(nextSpawn);
        if (Time.time > nextSpawn)
        {
            Instantiate(coin, pos, Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
        }

        
	}
}

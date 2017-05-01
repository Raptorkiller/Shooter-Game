using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    //public Vector3 offset;
    public GameObject bullet;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnBullet()
    {
        Instantiate(bullet,transform.position,transform.rotation);
    }
}

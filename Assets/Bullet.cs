using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletDamage;
    public float bulletVelocity;
    public float maxRange;

   
    private Vector3 spawnPosition;
    private Quaternion spawnRotation;
    private Vector3 currentPosition;
    private Rigidbody rigidBody;
   

    // Use this for initialization
    void Start () {
        spawnPosition = transform.position;
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        currentPosition = transform.position;
        
        if (Mathf.Abs(spawnPosition.z - currentPosition.z) < maxRange && Mathf.Abs(spawnPosition.x - currentPosition.x) < maxRange && Mathf.Abs(spawnPosition.y - currentPosition.y) < maxRange)
        {
            rigidBody.AddForce(transform.forward * bulletVelocity);
        }
        else
        {
            Destroy(gameObject);
        }

        
       
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        Health target = collision.gameObject.GetComponent<Health>();

        if (target && collision.gameObject.tag != "Player")
        {
            target.health -= bulletDamage;
            Destroy(gameObject);
        }
    }

    

}

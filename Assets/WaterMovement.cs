using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour {

    //private Player player;
    private Rigidbody playersRigidBody;

	// Use this for initialization
	void Start () {
        //player = FindObjectOfType<Player>();
        playersRigidBody = FindObjectOfType<Player>().GetComponent<Rigidbody>();
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        playersRigidBody.useGravity = false;
    }

    private void OnTriggerExit(Collider other)
    {
        playersRigidBody.useGravity = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public GameObject bullet;
    public float RPM;
    private float roundsPerSecond;
    private float fireRate;
    public Vector3 offSet;
    private Camera eyes;
    private float timer;
    
    // Use this for initialization
	void Start () {
        eyes = GetComponentInChildren<Camera>();
        roundsPerSecond = 60f / RPM;
        Debug.Log(roundsPerSecond);
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && timer <=0)
        {
            Instantiate(bullet, eyes.transform.position + offSet, eyes.transform.rotation);
            timer = roundsPerSecond; ;
        }
        else
        {
            
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int ammoCarried;

    private Weapon activeWeapon;

    private float timer;
    private float roundsPerSecond;
    public bool reloading = false;

    // Use this for initialization
    void Start () {
        activeWeapon = GetComponentInChildren<Weapon>();
        roundsPerSecond = 60f / activeWeapon.RPM;
        timer = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Reload") && ammoCarried != 0)
        {
            reloading = true;
            StartCoroutine(activeWeapon.Reload());
            
        } 


        timer -= Time.deltaTime;
        Debug.Log(timer -= Time.deltaTime);
        if (Input.GetButton("Fire1") && timer <= 0 && !reloading)
        {
            activeWeapon.Shoot();
            timer = roundsPerSecond;
        }
       
	}

   
}

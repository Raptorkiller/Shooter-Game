using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float RPM;
    public int ammo;
    public int ammoClipSize;
    public Vector3 offSet;
   
    private BulletSpawner bulletSpawner;
    private Player player;

    

    // Use this for initialization
    void Start () {
        bulletSpawner = GetComponentInChildren<BulletSpawner>();
        player = FindObjectOfType<Player>();
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    public void Shoot()
    {
        if(ammo > 0)
        {
            ammo--;
            bulletSpawner.SpawnBullet();
        }
        
    }

    public int Reload(int reload)
    {
       if(reload >= ammoClipSize)
        {
            ammo = ammoClipSize;
            return reload - ammoClipSize;
        }
        else
        {
            ammo = reload;
            return reload = 0;
        }
    }
}

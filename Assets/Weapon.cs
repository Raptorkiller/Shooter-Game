using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float RPM;
    public int ammo;
    public int ammoClipSize;
    
    public ParticleSystem muzzleFlash;
    public AudioClip shot;
    public AudioClip reload;
   
    private BulletSpawner bulletSpawner;
    private Player player;
    private RaycastHit hit;
    private AudioSource clip;
    //private float reloadTimer;
    


    

    // Use this for initialization
    void Start () {
        bulletSpawner = GetComponentInChildren<BulletSpawner>();
        player = FindObjectOfType<Player>();
        clip = GetComponent<AudioSource>();
        //reloadTimer = reload.length;
        
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
            muzzleFlash.Play();
            clip.clip = shot;
            clip.Play();
        }
        
    }



    public IEnumerator Reload()
    {


        clip.clip = reload;
        clip.Play();

        if (player.ammoCarried >= ammoClipSize)
        {
            yield return new WaitForSeconds(reload.length);
            ammo = ammoClipSize;
            player.ammoCarried = player.ammoCarried - ammoClipSize;
            player.reloading = false;

        }
        else
        {
            yield return new WaitForSeconds(reload.length);
            ammo = player.ammoCarried;
            player.ammoCarried = 0;
            player.reloading = false;
        }
    }


}

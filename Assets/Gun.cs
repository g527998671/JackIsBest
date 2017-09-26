﻿
using UnityEngine;

public class Gun : MonoBehaviour {

    public AudioClip shoot;

    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEfect;

    private float nextTimeToFire = 0f;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            GetComponent<AudioSource>().PlayOneShot(shoot);
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
		
	}

    void Shoot()
    {

        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * impactForce);
            }


            GameObject impactGO = Instantiate(impactEfect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 0.2f); 
        }
    }
}
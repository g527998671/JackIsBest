using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot666 : MonoBehaviour {
    public AudioClip BGM;

    // Use this for initialization
    void Start () {
		
	}
    public GameObject bulletprefab;
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().PlayOneShot(BGM);
            GameObject b = (GameObject)Instantiate(bulletprefab, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().velocity = transform.forward * 15;
        }
		
	}
}

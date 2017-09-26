using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGun : MonoBehaviour {
    public PlayerGun pg;

    void OnTriggerEnter(Collider other)
    {
        pg.hasGun = true;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

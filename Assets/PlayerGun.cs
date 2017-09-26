using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {

    public bool hasGun = false;
    public GameObject imageObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasGun)
        {
            imageObject.SetActive(true);
        }
		
	}
}

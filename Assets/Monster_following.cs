using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_following : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Transform player;
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * Time.deltaTime);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternatingRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float dtheta = 1;
    public float theta = 0;
	// Update is called once per frame
	void Update () {
		if(theta > 90)
        {
            dtheta = -1;
        }
        if(theta <0)
        {
            dtheta = 1;
        }
        theta = theta + dtheta;
        transform.Rotate(Vector3.forward * Time.deltaTime * 100 * dtheta);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsTriggerToNextLv : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("scene2", LoadSceneMode.Single);
    }
}

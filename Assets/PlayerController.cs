using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public Image image;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public int playersLife = 100;
    public AudioClip painClip;
    public Text txt;
	void Update () {
        txt.text = "" + playersLife;
        Color c = image.color;
        c.a = c.a - 0.04f;
        image.color = c;
		
	}
    public void TakeDamage()
    {
        

        if(playersLife <= 0)
        {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(painClip);
            playersLife = playersLife - 20;
            Color C = image.color;
            C.a = 1;
            image.color = C;
        }
    }

    public void HealDamage()
    {
        
        playersLife = playersLife + 10;
        
    }
}

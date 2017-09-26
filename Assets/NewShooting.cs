using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShooting : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bulletSpawn;
    float countdown = -1;
    public Transform player;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        countdown = countdown - Time.deltaTime;
        if (countdown < 0)
        {
            countdown = 1f;
            GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = transform.forward * 30;
            Destroy(obj, 5.0f);
        }

    }
}


using UnityEngine;
using System.Collections;

public class OpenSesame : MonoBehaviour
{
    public GameObject player;
    public bool opening = false;
    // Use this for initialization
    void Start()
    {

    }

    public void moveDown()
    {
        opening = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            transform.Translate(0, -Time.deltaTime / 2, 0);
        }
    }
}

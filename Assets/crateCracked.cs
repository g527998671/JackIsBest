using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateCracked : MonoBehaviour {

    public GameObject destroyedVersion;

    void OnMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
    }
}

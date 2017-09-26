
using UnityEngine;

public class Target : MonoBehaviour {

    public GameObject destroyedVersion;
    public float health = 50f;

    

    public void TakeDamage(float amout)
    {

        health -= amout;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
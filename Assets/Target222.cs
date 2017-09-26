
using UnityEngine;

public class Target222 : MonoBehaviour
{

    public GameObject destroyedVersion;
    public float health = 50f;



    public void TakeDamage(float amout)
    {

        health -= amout;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
    }

}
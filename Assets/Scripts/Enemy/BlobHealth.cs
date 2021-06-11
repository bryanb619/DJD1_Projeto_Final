using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHealth : MonoBehaviour
{
    // variables
    // Blob Health
    public int blobHealth;
    
    // damage method
    public void BlobDamage( int damage)
    {
        blobHealth -= damage;
        if (blobHealth <= 0)
        {
            BlobDeath();
        }
        if (blobHealth < 60)
        {
            Debug.Log("Health at 60%");
        }
    }
    void BlobDeath()
    {
        Destroy(gameObject);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHealth : MonoBehaviour
{
    // variables
    // Blob Health
    public int blobHealth = 100;
    
    // damage method
    public void BlobDamage( int damage)
    {
        blobHealth -= damage;
        if (blobHealth <= 0)
        {
            BlobDeath();
        }
    }
    void BlobDeath()
    {
        Destroy(gameObject);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobHealth : MonoBehaviour
{
    // variables
    // Blob Health
    [SerializeField]
    private int blobHealth = 120;
    // points for blob death
    private int points = 10;

    
    // damage method
    // uses damage variable from Fireball.cs 
    public void BlobDamage(int PlayerHit)
    {   // Blob - damage (Fire ball)
        blobHealth -= PlayerHit;
        // if true call death method
        if (blobHealth <= 0)
        { 
            // Call death method
            BlobDeath();

        }
    }
    // Blob Death Method
    void BlobDeath()
    {
        Destroy(gameObject);
    }
}

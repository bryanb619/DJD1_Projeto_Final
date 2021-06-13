using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    // Variables
    // Bullet Speed
    [SerializeField]
    private float speed = 20f;
    // Fire Ball damage
    private int damage = 20;
    // Rigidbody2D
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }
    // Collision detection 
    void OnTriggerEnter2D(Collider2D Contact)
    {
        
        // Search for for blob health script
        BlobHealth enemy = Contact.GetComponent<BlobHealth>();
        // inflict damage X on blob
        if ( enemy != null)
        {   // DEBUG
            Debug.Log("Blob Hit"); 
            enemy.BlobDamage(damage);
        }
        // Remove GameObject from scene
        Destroy(gameObject);

    }
}

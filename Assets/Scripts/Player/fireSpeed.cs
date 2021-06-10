using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSpeed : MonoBehaviour
{
    [SerializeField]
    // Bullet Speed
    private float speed = 20f;
    // Fire Ball damage
    private int damage = 20;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }
    // Collision detection 
    void OnTriggerEnter2D(Collider2D Contact)
    {
        Debug.Log("contact.name");

        BlobHealth enemy = Contact.GetComponent<BlobHealth>();
        if ( enemy != null)
        {   // 
            enemy.BlobDamage(damage);
        }
        Destroy(gameObject);

    }
}

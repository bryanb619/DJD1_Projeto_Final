using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   // Velocidade "PLAYER"
    public float movementeSpeed;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    bool isGrounded;
    // Layer Ground
    public LayerMask groundLayers;
    float mx;
    
    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded()) 
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementeSpeed, rb.velocity.y);
        rb.velocity = movement;

    }
    // Salto
    private void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }
    // checa pelo ground
    public bool IsGrounded()
    {
        Collider2D groundcheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        if (groundcheck != null)
        {
            return true;
        }

        return false;
    }

}


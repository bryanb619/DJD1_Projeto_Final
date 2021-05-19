using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb;
    //player speed (left/right)
    public float Playerspeed;
    //Input do jogador??
    private float motionInput;
    //Força de salto(editavel no editor)
    public float jumpForce; 
    //Layer de ground
    private bool Grounded;
    //Empty object nos pes do jogador, em contacto com ground permite saltar
    public Transform PlayerFeet;
    public float checkRadius;
    // para ser usado em superficies liquidas como agua, lama e etc...
    public LayerMask whatIsGround;
    //temporazidores de salto
    private float jumpTimer;
    public float jumpTime;
    //previne double jumps
    private bool IsPlayerJumping; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        motionInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(motionInput * Playerspeed, rb.velocity.y);
    }
    void Update()
    {
        Grounded = Physics2D.OverlapCircle(PlayerFeet.position, checkRadius, whatIsGround);
        // códgio de salto
        if(Grounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            IsPlayerJumping = true;
            jumpTimer = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKey(KeyCode.Space) && IsPlayerJumping == true)
        {
            if (jumpTimer > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimer -= Time.deltaTime;
            }
            else IsPlayerJumping = false;
                
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            IsPlayerJumping = false;

        }
    }
    
}

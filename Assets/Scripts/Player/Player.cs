using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variables
    private Rigidbody2D rb;
    //player speed (left/right)
    [SerializeField]
    private float Playerspeed;
    //Input do jogador??
    private float motionInput;
    //Força de salto(editavel no editor)
    [SerializeField]
    private float jumpForce; 
    //Layer de ground
    private bool Grounded;
    //Empty object nos pes do jogador, em contacto com ground permite saltar
    public Transform PlayerFeet;
    public Transform PlatformChecker;
    public float checkRadius;
    // para ser usado em superficies liquidas como agua, lama e etc...
    [SerializeField] 
    private LayerMask whatIsGround;
    //temporazidores de salto
    [SerializeField]
    private float jumpTimer;
    public float jumpTime;
    //previne double jumps
    private bool IsPlayerJumping;
    // Player flip Bool
    private bool isFacingRight;



    /* flip do jogador
    [SerializeField]
    private bool isFacingRight = true;
    */

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // player starts looking to the right
        isFacingRight = true;
    }

    void FixedUpdate()
    {
        motionInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(motionInput * Playerspeed, rb.velocity.y);
        PlayerFlip(motionInput);
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
    // Not Working yet
    void OnCollissionEnter(Collider collision)
        {
            if(collision.tag == "movingPlatform")
            {   
                Debug.Log("Hit Platform");
                this.transform.parent = collision.transform;
            }
        }
        void OnCollissionExit(Collider collision)
        {
            if(collision.gameObject.name.Equals("movingPlatform"))
            {
                this.transform.parent = null;
            }
        }    
    public void PlayerDeath()   
    {
        FindObjectOfType<GeneralManager>().Restart();
    }   
    // player flip right to left
    private void PlayerFlip(float motionInput) // (jogador nao disparar em si próprio)
    {
        if(motionInput > 0 && !isFacingRight || motionInput < 0 && isFacingRight)
        {   
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;
            transform.localScale = theScale;
        }

      
    }
}

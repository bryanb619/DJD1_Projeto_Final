using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    // Components
    // Rigidbody2D
    private Rigidbody2D rb;

    private CapsuleCollider2D cc;

    // Variables
    //player speed (left/right)
    [SerializeField]
    private float Playerspeed;
    // Player input
    private float motionInput;
    //Força de salto(editavel no editor)
    [SerializeField]
    private float jumpForce; 
    //Layer de ground
    private bool Grounded;
    // Layer detection (operates like a feet, if feet in air, no jump)
    public Transform PlayerFeet;
    public Transform PlatformChecker;
    // Radius of layer check
    public float checkRadius;
    [SerializeField] 
    private LayerMask whatIsGround;
    // Jump timer
    [SerializeField]
    private float jumpTimer;
    public float jumpTime;
    //previne double jumps
    private bool IsPlayerJumping;
    // Player flip Bool
    // player starts looking to the right, so true
    private bool isFacingRight = true;
    // extra Fall force to player 
    [SerializeField]
    private float fallMultiplier;
    //
    [SerializeField]
    private float lowJumpMultiplier;
    //
    public PhysicsMaterial2D Friction;
    public PhysicsMaterial2D noFriction;


    // Start is called before the first frame update
    void Start()
    {
        // Player Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // motionInput
        motionInput = Input.GetAxis("Horizontal");

        // Player speed
        rb.velocity = new Vector2(motionInput * Playerspeed, rb.velocity.y);


        // If player switches direction call this method
        Flip(motionInput);

    }
    void Update()
    {
        Grounded = Physics2D.OverlapCircle(PlayerFeet.position, checkRadius, whatIsGround);

        // Jump conditions
        // if space is hit 
        if(Grounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            IsPlayerJumping = true;
            jumpTimer = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        // if space is hold
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
        //  extra Gravity pull to fix floatness issues
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier -1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {   
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier -1) * Time.deltaTime;
        }
    
    }
    // Player flip direction (used specially for shooting)
     private void Flip(float motionInput)
     {  
        //checks for player input (left or right)
        if(motionInput > 0 && !isFacingRight || motionInput < 0 && isFacingRight)
        {
            isFacingRight = !isFacingRight;
            // rotate 180 on Y axis (flip)
            transform.Rotate(0f, 180f, 0f);
        }
     }

    // Not Working yet
    // Platform parenting
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
    // Player Death Method   
    public void PlayerDeath()   
    {
        // Load Restart Scene
        FindObjectOfType<GeneralManager>().Restart();
    }  
    
    /* UNUSED TO BE DELETED
    // player flip right to left
    private void PlayerFlip(float motionInput) // (jogador nao disparar em si próprio)
    {
        if(motionInput > 0 && !isFacingRight || motionInput < 0 && isFacingRight)
        {   
            isFacingRight = !isFacingRight;
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;
            transform.localScale = theScale;


            // isFacingRight = !isFacingRight;
            //transform.Rotate(0f, 180f, 0f);
        }     
    }
    */
}

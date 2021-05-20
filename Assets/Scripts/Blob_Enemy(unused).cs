using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob_Enemy : MonoBehaviour
{   
    private Rigidbody2D rb;
    [SerializeField]
    // Velocidade padrão
    private float blobSpeed = 2.0f;
    [SerializeField]
    //Direção de movimento
    private float moveDir = 1.0f;
    [SerializeField] 
    //objeto vazio,(entra em colisão com ground Layer)
    private Transform GroundCheck;
    [SerializeField]
    private float groundCheckRadius = 3.0f;
    [SerializeField]
    private LayerMask groundCheckLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {   // detecção de ground
        Collider2D collider = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, groundCheckLayer);
        bool isGround = (collider != null);
        // condições de retorno
        if(!isGround)
        {
            moveDir = - moveDir;
        }
        // movimento inimigo (editavel no unity)
        Vector2 currentVelocity = rb.velocity;
        currentVelocity.x = moveDir * blobSpeed;
        rb.velocity = currentVelocity;

        if (currentVelocity.x < -0.1)
        {
            Vector3 curretRotation = transform.rotation.eulerAngles;
            currentVelocity.y = 180;
            transform.rotation = Quaternion.Euler(curretRotation);
        }
        else if ( currentVelocity.x > 0.1)
        {
            Vector3 currentRotation = transform.rotation.eulerAngles;
            currentRotation.y = 0;
            transform.rotation = Quaternion.Euler(currentRotation);
        }
    }
}

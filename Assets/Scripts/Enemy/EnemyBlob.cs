using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlob : MonoBehaviour
{
    Rigidbody2D blob_rb;

    [SerializeField]
    private Transform castPos;
    // enemy speed
    [SerializeField]
    private float speed;
    //
    [SerializeField]
    private float baseCastDist; 

    // enemy rotation (left and right)
    const string LEFT = "left";
    const string RIGHT = "right";

    string Enemyfacing;

    Vector3 baseScale;
   

    // Start is called before the first frame update
    void Start()
    {   // 
        baseScale = transform.localScale;
        Enemyfacing = RIGHT;
        blob_rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {   
        // Local speed variable
        float xSpeed = speed;

        if( Enemyfacing == LEFT)
        {
            xSpeed = -speed;
        }
        // blob speed
        blob_rb.velocity = new Vector2(xSpeed, blob_rb.velocity.y);
        
        if(Barrier() || NoGround())
        {
            // Debug code (CODE IS FUNCIONAL)
            Debug.Log("Hit");
            if(Enemyfacing == LEFT)
            {
                changeDir(RIGHT);
            }
            // RIGHT rotation
            else 
            {
                changeDir(LEFT);
            }
            
        }
    }

    // Blob direction change
    void changeDir(string NewDir)
    {
        Vector3 newScale = baseScale;

        if(NewDir == LEFT)
        {
            newScale.x = -baseScale.x;

        }
        // right 
        else
        {
            newScale.x = baseScale.x;
        }

        transform.localScale = newScale;
        Enemyfacing = NewDir;
        
    }

    // Wall/Barrier colision prevention bool
    bool Barrier()
    {
        bool value = false;

        float castDist =  baseCastDist;
        // 
        if(Enemyfacing == LEFT)
        {
            castDist = - baseCastDist;
        }
        // for safety, but not necessary!
        else
        {
            castDist = baseCastDist;
        }

        // Line Casting direction
        Vector3 targetPos = castPos.position;
        targetPos.x += castDist;

        // Line inside Unity Editor
        Debug.DrawLine(castPos.position, targetPos, Color.red);

        // Line detection
        if(Physics2D.Linecast(castPos.position, targetPos, 1 << LayerMask.NameToLayer("Ground")))
        {
            value = true;

        }
        else 
        {
            value = false;
        }

        return value;
    }

    // End of ground detection
    bool NoGround()
    {
        bool value = true;

        float castDist =  baseCastDist;
        // Line Casting direction
        Vector3 targetPos = castPos.position;
        targetPos.y -= castDist;

        // Line inside Unity Editor
        Debug.DrawLine(castPos.position, targetPos, Color.green);

        // Line detection
        if(Physics2D.Linecast(castPos.position, targetPos, 1 << LayerMask.NameToLayer("Ground")))
        {
            value = false;

        }
        else 
        {
            value = true;
        }
        // returns method value
        return value;
    }
    
}

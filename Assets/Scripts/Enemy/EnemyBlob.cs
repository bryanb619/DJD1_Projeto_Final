using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlob : MonoBehaviour
{
    // Variables
    // Blob Rigidbody2D
    Rigidbody2D blob_rb;
    // Raycast Position
    [SerializeField]
    private Transform castPos;
    // Blob speed
    [SerializeField]
    private float speed;
    // Size of Raycast line 
    [SerializeField] 
    private float baseCastDist;
    // enemy constant string rotation (left and right)
    private const string LEFT = "left";
    private const string RIGHT = "right";
    // Enemy Facing direction
    private string Enemyfacing;
    Vector3 baseScale;
   
    // Start is called before the first frame update
    void Start()
    {   
        // 
        baseScale = transform.localScale;
        // righ by default
        Enemyfacing = RIGHT;
        // standard Rigidbody2D
        blob_rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {   
        // Local speed variable
        float xSpeed = speed;

        if( Enemyfacing == LEFT)
        {
            xSpeed = -speed;
        }
        // blob speed normal speed
        blob_rb.velocity = new Vector2(xSpeed, blob_rb.velocity.y);

        // if hit barrier or no ground
        if(Barrier() || NoGround())
        {
           
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

    // Wall/Barrier colision prevention booleans
    bool Barrier()
    {
        // false by default
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
        // returns to method value (true or false)
        return value;
    }

    // End of ground detection
    bool NoGround()
    {
        // false by default
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
        // returns to method value (true or false)
        return value;
    }  
}

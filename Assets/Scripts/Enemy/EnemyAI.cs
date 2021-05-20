using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
Código geral dos inimgos
neste momento só há o inimigo "enemy_01"*/
public class EnemyAI : MonoBehaviour
{   // velocidade do inimigo_01
    public float speed = 2f;
    // adiciona velocidade
    public Rigidbody2D rb;
    // Layer do ground
    public LayerMask groundLayers;
    public Transform groundCheck;
    //
    bool isFacingRight = true;

    // da informação sobre o que deu "hit", em que colidiu
    // previne queda da plataforma
    RaycastHit2D hit;

    private void Update()
    {   // faz raycast para baixo, para ver se atinge Ground
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);

    }

    private void FixedUpdate()
    {

        if(hit.collider != false)
        {   // muda a direção do inimigo_01 sempre que atinge o limite
           if (isFacingRight)
           {
               rb.velocity = new Vector2(speed, rb.velocity.y);
           }
           else{
               rb.velocity = new Vector2(- speed, rb.velocity.y);
           }
        }
        else 
        {   // vai ser simplesmente o oposto, se não estou facing right, estou facing left
            isFacingRight = !isFacingRight;
            // fazer rotação
            transform.localScale = new Vector3(-transform.localScale.x, 1f, 1f);
        }


    }



    
}

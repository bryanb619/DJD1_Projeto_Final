using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
Código geral dos inimigos
neste momento só há o inimigo "enemy_01"*/
public class EnemyAI : MonoBehaviour
{   // velocidade do inimigo_01
    [SerializeField] private float speed;
    // adiciona velocidade
    public Rigidbody2D rb;
    // Layer do ground
    public LayerMask groundLayers;
    // transform dentro do unity
    public Transform groundCheck;
    bool isFacingRight = true;

    // da informação sobre o que deu "hit", em que colidiu
    // previni queda da plataforma
    RaycastHit2D noGround;

    private void Update()
    {   // faz raycast para baixo, para ver se atinge Ground
    
        noGround = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);

    }

    private void FixedUpdate()
    {

        if(noGround.collider != false)
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

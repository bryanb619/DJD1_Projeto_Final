using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathZone : MonoBehaviour
{  // se colidir com enemy_01. Morte!
    private void OnColisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemytag"))
        {   // destroy o jogador
            Destroy(gameObject);
            // respawn imediatamente após a morte
            GeneralManager.instance.Respawn();
        }
    }

    // Outras tipos de mortes!
}



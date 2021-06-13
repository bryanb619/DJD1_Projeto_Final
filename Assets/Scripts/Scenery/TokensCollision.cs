using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokensCollision : MonoBehaviour
{
    // 
    void OnPlayerEnter(Player player)
    {
        RemoveTokens(player);
        // acessing PlayerScoreScript and AddPoint
        PlayerScore.instance.AddPoint();
    }
    

    void OnTriggerEnter2D(Collider2D PointHit )
    {


    }
    void RemoveTokens(Player player)
    {

    }
}

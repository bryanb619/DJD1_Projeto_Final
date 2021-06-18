using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenCollector : MonoBehaviour
{   
    // variables

    // starting number of tokens = 0 
    private float token = 0;
    // Text Token on UI 
    public Text TokenCounter;
    private int points = 20;

    // on collision event
    private void OnTriggerEnter2D(Collider2D tok)
    {
        // "if Player" contacts "Token"
        if (tok.transform.tag == "Token")
        {
            // increment token number
            token++;

            // use token text and update token count
            TokenCounter.text = token.ToString();

            // destroy Token
            Destroy(tok.gameObject);
        }

    }
}

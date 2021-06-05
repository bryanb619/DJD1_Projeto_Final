using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobAIPersue : MonoBehaviour
{
    public GameObject PlayeObject;
    [SerializeField]
    private Transform PlayerPosition;
    private Vector2 currentPos;
    public float distance;
    [SerializeField]
    private float Speed;

    // Start is called before the first frame update
    void Start()
    {

        PlayerPosition = PlayerPosition.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, PlayerPosition.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerPosition.position, Speed * Time.deltaTime);
        }
        else
        {   
            if(Vector2.Distance(transform.position, currentPos)<= 0)
            {

            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, Speed * Time.deltaTime);
            }
        }
    }
}

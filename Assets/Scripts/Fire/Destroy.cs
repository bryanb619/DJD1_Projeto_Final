using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    float destroyTime = 2f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

}

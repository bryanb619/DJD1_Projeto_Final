using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_behaviour : MonoBehaviour
{   //Follows a target
    public Transform target;
    //speed
    public float followspeed = 10f;
    // 
    public Vector3 cameraOffset;

    // Fixed Update, corre no maximo ate um certo FPS 
    void FixedUpdate()
    {   //
        transform.position = target.position;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{   
    // Variables
    // Link to moving Platform
    public Transform plataform;
    //
    public List<Transform> points;
    //
    private int objectivePoint=0;
    // Platform moving speed
    [SerializeField]
    private float PlatformSpeed;

    // Methods
    // update every FPS
    void Update()
    {
        // call next point
        NextPoint();
    }
    void NextPoint()
    {
        // Move tomwards next Point
        plataform.position= Vector2.MoveTowards(plataform.position, points[objectivePoint].position, Time.deltaTime*PlatformSpeed);

        //Check if plataform in close range to point
        if(Vector2.Distance(plataform.position, points[objectivePoint].position) < 0.1f)
        {
            // 
            if(objectivePoint == points.Count-1)
            {
                objectivePoint = 0;
            }
            else
            {
                objectivePoint++;
            }
            
        }
    }
}

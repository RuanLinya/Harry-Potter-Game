using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongWaypoints : MonoBehaviour
{
    public float velocity = 3;      // Variable for the velocity of the cube
    public float distanceMax = 1;   // Variable for the distance at which the next point should be targeted

    public Transform[] Targets;     // Array holding the points, the cube wants to navigate to
    private int targetID = 0;       // index of the Array
    
    // Update is called once per frame
    void Update()
    {
        MoveUsingWaypoints();       // To keep our Update function clear, we put all the movement related code to a new function below and call the function in Update
    }

    public void MoveUsingWaypoints()
    {
        if (targetID < Targets.Length)  // As long as the targetID is lower than the number of Points in our Waypoints array, the cube moves. Otherwise we set the targetID to 0 and start from the beginning.
        {
            Vector3 heading = Targets[targetID].position - this.transform.position;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance;

            this.transform.position += direction * velocity * Time.deltaTime;  // shorthand

            if (distance < distanceMax) // If the cube is close enough to a point, the targetID is increased, so the next point is targeted
            {
                targetID++;     // shorthand for targetID = targetID + 1 or targetID += 1
                Debug.Log("The cube is heading towards Point " + targetID); // This line gives us an output to the console whenever the cube aims for another point.
            }
        }
        else
        {
            targetID = 0;
        }
    }
}

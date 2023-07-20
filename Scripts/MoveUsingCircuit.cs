using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;  // This line let's c# know, that we want to use the StandardAsset.Utility namespace for the WaypointProgressTracker

public class MoveUsingCircuit : MonoBehaviour
{
    public float velocity = 3;  // Variable for the velocity of the cube
    private Transform Target;   // Transform for the Target from the WaypointProgressTracker
    
    void Update()
    {
        // As we do not have a target yet, we want to set it once. The if expression checks, whether the Transform variable "Target" exists.
        if (!Target)
            Target = GetComponent<WaypointProgressTracker>().target;    // Referencing the "target" variable from the WaypointProgressTrackerScript, which needs to be located on the same GameObject as the script calling the function

        Vector3 heading = Target.position - this.transform.position;
        float distance = heading.magnitude;
        Vector3 direction = heading / distance;

        this.transform.position += direction * velocity * Time.deltaTime;

        // To make the cube rotate towards the next target, we use the Transform.LookAt() function.
        this.transform.LookAt(Target);
    }
}

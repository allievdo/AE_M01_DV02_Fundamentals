using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

//public class Wander : Face
//{
//    //the radius and forward offset of the wander circle
//    float wanderOffset;
//    float wanderRadius;

//    float targetAngle;

//    // the maximum rate at which the wander orientation can change
//    float wanderRate;

//    //the current orientation of the character
//    float wanderOrientation;

//    // the maximum acceleration of the character
//    float maxAcceleration;

//    public float randomBinomial()
//    {
//        float random = Random.value - Random.value;
//        random *= Mathf.Rad2Deg;
//        return random;
//    }

//    public override SteeringOutput getSteering()
//    {
//        //update the wander orientation
//        wanderOrientation += randomBinomial() * wanderRate;

//        //calculate the combined target orientation
//        targetAngle = wanderOrientation + character.transform.eulerAngles.y;

//        //calculate the center of the wander circle
//        targetAngle = character.transform.position.y + wanderOffset * character.transform.eulerAngles.y;


//        return base.getSteering();
//    }
//}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,0,1);       Moves forward 
        transform.Translate(Vector3.forward);     // Vectors3 is the 3D representations of vectors and points 
                                                  //forward -- 0,0,1
    }
}

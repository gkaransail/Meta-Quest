using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{   
    public float speed = 10.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");



       
        //  Moves forward 
        transform.Translate(Vector3.forward * Time.deltaTime*speed*forwardInput);     // Vectors3 is the 3D representations of vectors and points 
        //transform.Translate(Vector3.right * Time.deltaTime*turnSpeed*horizontalInput);   

        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);                                  
    }
}

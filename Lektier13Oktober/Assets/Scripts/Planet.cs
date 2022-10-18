using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    //Code from "Rotating around an object (Unity Tutorial), Ketra Games, Youtube
    public float rotationSpeed;
    
    //Code from LEARN UNITY - The Most BASIC TUTORIAL I'll ever make, Imphenzia, Youtube
    
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;

    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //Check if space key is pressed
       if (Input.GetKeyDown(KeyCode.Space))
       {
        jumpKeyWasPressed = true;
       } 

       horizontalInput = Input.GetAxis("Horizontal");
        
        //Code from "Rotating around an object (Unity Tutorial), Ketra Games, Youtube
       transform.Rotate(new Vector3(0,rotationSpeed, 0) * Time.deltaTime);
    }
    
    //FixedUpdate is called once every physics update
   private void FixedUpdate()
   {
    if (jumpKeyWasPressed)
    {
        rigidbodyComponent.AddForce(Vector3.up * 2, ForceMode.VelocityChange);
        jumpKeyWasPressed = false;
    }

    rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);
    
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kugle : MonoBehaviour
//Code from "Rotating around an object (Unity Tutorial), Ketra Games, Youtube

{

    public float rotationSpeed;

    
    void Start()
    {
        
    }

    void Update()
    {
        
       transform.Rotate(new Vector3(0,rotationSpeed, 0) * Time.deltaTime);
    }
}

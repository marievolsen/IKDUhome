using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetRotate : MonoBehaviour
//Code from "Rotating around an object (Unity Tutorial), Ketra Games, Youtube

{
    public float rotationSpeed;
    public GameObject pivotObject;

    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(1, 0, 0), rotationSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
     This script is responsible for the ball rotating around the circle and it can switch the center when the circle gets changed.


    
 */

public class PointDir : MonoBehaviour
{

    

    public Transform[] rotationCenter;  //for large level we can increase the points and Instantiate more circle around it.

    [HideInInspector]
    public int i = 0;

    public float speed = 10;
    Rigidbody2D rb;

    Vector3 offset =new Vector3(0, 0, 1);  // We can also change rotation around circle clockwise/anti-clockwise by this variable.



    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

   
    void Update()
    {

        rb.bodyType = RigidbodyType2D.Static;
        
        transform.RotateAround(rotationCenter[i].transform.position, offset, speed * Time.deltaTime); //Remove gravity & Rotate object around circle


    }
}

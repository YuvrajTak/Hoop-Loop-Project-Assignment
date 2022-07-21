using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHandler : MonoBehaviour
{



    public Transform[] rotationCenter;

    public  int i = 0;

  

    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f;

    public float posX, posY;
       public float angle = 120f;


    // Start is called before the first frame update
    void Start()
    {
      //  transform.position = rotationCenter[i].transform.position + new Vector3(10, 155,0);

       // Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
         //	rb.isKinematic = false;

            //rb.IsSleeping();
           
            posX = rotationCenter[i].position.x + Mathf.Cos(angle) * rotationRadius;
            posY = rotationCenter[i].position.y + Mathf.Sin(angle) * rotationRadius;
            transform.position = new Vector2(posX, posY);

            


            angle = angle + Time.deltaTime * angularSpeed;




            if (angle >= 360f)
                angle = 0f;



    }
}

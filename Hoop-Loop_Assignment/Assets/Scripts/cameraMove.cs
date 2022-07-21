using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    /*
     This is just a temporary  script for debugging and see the movement after first jump.
    
     */



    public Transform player;

    [HideInInspector]
    public bool isChange= false;
   

   
    // Update is called once per frame
    void LateUpdate()
    {


        if (isChange == true)
        {
            if (transform.position.y <= 386)
            {
                return;
            }
            transform.Translate(0f, -1.5f * Time.fixedDeltaTime, 0f);
        }

    }



}

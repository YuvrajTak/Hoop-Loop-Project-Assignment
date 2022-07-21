using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{

    /*

   - This script is responsible for making our pivot point direction always tangent to the circle.
    - When we switch/Jump from one circle to another circle, our circle and their child pivot point is also rotate.
    -To Fix this issue when rotating around the circle our pivot will always rotate and be in tanget (-vector.rigth) direction.
    -When we apply input  than this script will be disable and when collide to new center it will switch to another circles center's tanget direction.
    */

    public Transform[] target;

    

    public PointDir pd;
    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target[pd.i].position - transform.position;
        transform.rotation = Quaternion.FromToRotation(-Vector3.right, direction);

    }



}

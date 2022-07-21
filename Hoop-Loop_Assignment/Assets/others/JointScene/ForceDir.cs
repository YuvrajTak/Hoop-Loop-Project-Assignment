using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceDir : MonoBehaviour
{
    Rigidbody2D rb;
    DistanceJoint2D dj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // dj.maxDistanceOnly(1.6f);
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 pt= rb.GetRelativePointVelocity(transform.position);

        rb.AddForce(pt);


    }
}

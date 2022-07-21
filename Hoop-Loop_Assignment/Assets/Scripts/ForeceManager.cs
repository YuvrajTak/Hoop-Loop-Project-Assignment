using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ForeceManager : MonoBehaviour
{

    /*

This script is responsible for appling force in the direction of pivot point when it get input.

    when we click on UI element then it will not accept the input.


*/

    public Rigidbody2D rb;
    PointDir pr;
    
    public float force=5;
    private Torque tq;
    public BallTaker bt;
    public GameObject points;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pr = GetComponent<PointDir>();
        tq = GetComponent<Torque>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }

          
          
            pr.enabled = false;
            Debug.Log("ForceApplied");


            rb.bodyType = RigidbodyType2D.Dynamic; //when it leave circle then it will be dynamic type of object, gravity will apply
                                                  //toward downside and force in tangent direction 

                                                  //Thus it will get a natural parabolic movement according to physics.


            Debug.Log(rb.bodyType);
            ApplyForce();
            tq.enabled = false;

            StartCoroutine(circleEnable(pr.i)); // This is very useful  if we come again the same circle after jump. 
        }

        if (Input.GetMouseButtonUp(0))
        {
           
        }

       

        void ApplyForce()
        {
            //   Vector2 direction = point.transform.position - transform.position;
           


            Vector2 startPoint = transform.position;
            Vector2 endPoint = points.transform.position;

            Vector2 direction = (endPoint - startPoint).normalized; //To make apply force direction toward tangent (pivot point) direction.
            Vector2 force = direction * 10;
            Debug.Log(direction);
            rb.AddForce(force, ForceMode2D.Impulse);

            
        }
    }
    private IEnumerator circleEnable(int e)
    {

        yield return new WaitForSeconds(1f);
        tq.enabled = true;
        bt.cc[e].enabled = true;
       
       
    }

}

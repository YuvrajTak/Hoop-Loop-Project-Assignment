using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{
   // public Transform point;
   // PointDir pr;
   // RotateObject ro;
   // Rigidbody2D rb;

   // public GameObject points;

   // public int thrust = 10;


   //// public GameObject[] DestoryObj;





   // // Start is called before the first frame update
   // void Start()
   // {
   //   //  ro = GetComponent<RotateObject>();

   //     pr = GetComponent<PointDir>();
   // }

   // // Update is called once per frame
   // void Update()
   // {
        


   //      //   float tan = RotateObject.posX / RotateObject.posY;

   //     // rb.AddForce(transform.up * thrust);

   //     if (Input.GetMouseButtonDown(0))
   //     {
   //         ApplyForce();
   //     }
          


   // }


   // void ApplyForce()
   // {
   //     //   Vector2 direction = point.transform.position - transform.position;
   //     //    rb.AddForceAtPosition(direction.normalized, transform.position);
   //     ro.enabled = false;

   //     rb.bodyType = RigidbodyType2D.Dynamic;


   //     Vector2 startPoint = transform.position;
   //     Vector2 endPoint = points.transform.position;

   //     Vector2 direction = (endPoint - startPoint).normalized;
   //     Vector2 force = direction * 10;
   //     Debug.Log(direction);
   //     rb.AddForce(force, ForceMode2D.Impulse);
   // }


   // public void AddForceAtAngle(float force, float angle)
   // {


   //         ro.enabled = !ro.enabled;

   //         rb.bodyType = RigidbodyType2D.Dynamic;

        
   //         float xcomponent =  Mathf.Cos(angle * Mathf.PI / 180) * force;
   //         float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;
   //         Vector2 f = new Vector2(ycomponent, xcomponent);

   //     rb.angularVelocity = 0f;

   //     rb.AddForce(f);
        
   // }


   // public void changeScene()
   // {
   //   //  foreach(GameObject g in DestoryObj)
   //     {
   //     //    Destroy(g);
   //     }


   //     SceneManager.LoadScene(SceneManager.GetActiveScene().name); 


   // }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallTaker : MonoBehaviour
{

    /*

  - This script is responsible for mainly context switching of the circle.
  - For long level where we need too many circles, we can Instantiating these same circles and destroy the previous once.
  - We can also used object pooling  for quickly load & good performance.


   */

    

    public ForeceManager fm;
    public PointDir pt;
    public cameraMove cm;

    public Rigidbody2D rb;
    public Torque tq;
    public CircleCollider2D[] cc;



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("C1"))
        {
            pt.i = 0;
            pt.enabled = true;
            tq.enabled = true;
            cc[0].enabled = false;
        }


        if (other.gameObject.CompareTag("C2"))
        {
            pt.i = 1;
            tq.enabled = true;
            pt.enabled = true;
            Debug.Log("C2 Enter");
            cc[1].enabled = false;
            cm.isChange = true;
        }


        if (other.gameObject.CompareTag("C3"))
        {
            pt.i = 2;
            tq.enabled = true;
            pt.enabled = true;
            cc[2].enabled = false;
        }

        if (other.gameObject.CompareTag("wall")) { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
      
    }

    /// <summary>
    /// To restart scene
    /// </summary>

    public void changeScene(){SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
    


    /// <summary>
    /// To load main menu.
    /// </summary>
    public void menuScene() { SceneManager.LoadScene(0); }
   


}




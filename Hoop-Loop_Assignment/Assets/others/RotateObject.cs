using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour 
{

	/*

	
It could an alternative way to rotate the object around the circle.



*/

	public Transform[] rotationCenter;

	public static int i=0;

	Rigidbody2D rb;

	[SerializeField]
	float rotationRadius = 2f, angularSpeed = 2f;

	public static float posX, posY, angle = 0f;

    private void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
	{
		 Rotate();
	}


	public void Rotate()
    {
		//	rb.isKinematic = false;

		//rb.IsSleeping();
		rb.bodyType = RigidbodyType2D.Static;
		posX = rotationCenter[i].position.x + Mathf.Cos(angle) * rotationRadius;
		posY = rotationCenter[i].position.y + Mathf.Sin(angle) * rotationRadius;
		transform.position = new Vector2(posX, posY);
		angle = angle +  angularSpeed* Time.deltaTime;

		if (angle >= 360f)
        {
			angle = 0f;
        }
			

	}

	


}

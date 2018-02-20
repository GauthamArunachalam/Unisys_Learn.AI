using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
	Rigidbody rb;
	public float speed = 1000.0f;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float Hmove = Input.GetAxis ("Horizontal");
		float Vmove = Input.GetAxis ("Vertical");

		Vector3 moveball = new Vector3 (Hmove, 0.0f, Vmove);
		rb.AddForce (moveball * speed * Time.deltaTime);
			
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    [Range(0f, 100f)]public float speed;

    // Use this for initialization
    void Start ()
	{
	    rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float moveHorizontal = Input.GetAxis("Horizontal");
	    float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed));
        //rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed);
        //rb.velocity = transform.forward * (moveVertical * speed);
	    transform.Rotate(0, moveHorizontal, 0);
	}
}

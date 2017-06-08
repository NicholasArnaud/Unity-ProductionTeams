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
        transform.Translate(0, 0, moveVertical);
	    transform.Rotate(moveHorizontal, 0, 0);
	}
}

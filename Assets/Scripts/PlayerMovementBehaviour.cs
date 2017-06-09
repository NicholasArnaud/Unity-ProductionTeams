using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementBehaviour : MonoBehaviour
{
    //private Rigidbody rb;
   // [Range(0f, 100f)]public float speed;

    public float maxAngle = 30f;
    public float maxTorque = 300f;
    public float brakeTorque = 30000f;

    public float criticalSpeed = 5f;
    public int stepsBelow = 5;
    public int stepsAbove = 1;

    public GameObject wheelShape;
    private WheelCollider[] m_Wheels;

    // Use this for initialization
    void Start ()
	{
	    //rb = GetComponent<Rigidbody>();



	    m_Wheels = GetComponentsInChildren<WheelCollider>();

	    for (int i = 0; i < m_Wheels.Length; i++)
	    {
	        var wheel = m_Wheels[i];
	    }
	}
	
	// Update is called once per frame
	void Update ()
	{
	    m_Wheels[0].ConfigureVehicleSubsteps(criticalSpeed, stepsBelow, stepsAbove);

        float angle = maxAngle * Input.GetAxis("Horizontal");
	    float torque = maxTorque * Input.GetAxis("Vertical");

	    float handBrake = Input.GetKey(KeyCode.X) ? brakeTorque : 0;

	    foreach (WheelCollider wheel in m_Wheels)
	    {
	        if (wheel.transform.localPosition.z > 0)
	            wheel.steerAngle = angle;

	        if (wheel.transform.localPosition.z < 0)
	            wheel.brakeTorque = handBrake;

	        if (wheel.transform.localPosition.z < 0)
	        {
	            wheel.motorTorque = torque;
	        }

	        if (wheel.transform.localPosition.z >= 0)
	        {
	            wheel.motorTorque = torque;
	        }
	        if (wheelShape)
	        {
	            Quaternion q;
	            Vector3 p;
	            wheel.GetWorldPose(out p, out q);

	            // Assume that the only child of the wheelcollider is the wheel shape.
	            Transform shapeTransform = wheel.transform.GetChild(0);
	            shapeTransform.position = p;
	            shapeTransform.rotation = q;
	        }
	        
        }

        //rb.AddForce(new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed));
        //rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed);
        //rb.velocity = transform.forward * (moveVertical * speed);
	    //transform.Rotate(0, moveHorizontal, 0);
	}
}

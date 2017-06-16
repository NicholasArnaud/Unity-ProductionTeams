using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementBehaviour : MonoBehaviour
{
    public float brakeTorque = 30000f;

    public float criticalSpeed = 5f;

    private WheelCollider[] m_Wheels;
    //private Rigidbody rb;
    // [Range(0f, 100f)]public float speed;

    public float maxAngle = 30f;
    public float maxTorque = 300f;
    public int stepsAbove = 1;
    public int stepsBelow = 5;

    private Animator animator;

    // Use this for initialization
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        m_Wheels = GetComponentsInChildren<WheelCollider>();

        for (var i = 0; i < m_Wheels.Length; i++)
        {
            var wheel = m_Wheels[i];
        }
    }

    // Update is called once per frame
    private void Update()
    {
        m_Wheels[0].ConfigureVehicleSubsteps(criticalSpeed, stepsBelow, stepsAbove);

        var angle = maxAngle * Input.GetAxis("Horizontal");
        var torque = maxTorque * Input.GetAxis("Vertical");

        var handBrake = Input.GetKey(KeyCode.X) ? brakeTorque : 0;

        if (Input.GetKey(KeyCode.R))
            transform.rotation = Quaternion.Euler(0, 0, 0);

        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene(0);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Reverse", false);
            animator.SetBool("Forward", true);
        }
            
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Reverse", true);
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetBool("RightTurn", false);
            animator.SetBool("LeftTurn", true);
        }          

        if(Input.GetKey(KeyCode.D))
        {
            animator.SetBool("LeftTurn", false);
            animator.SetBool("RightTurn", true);
        }

        if(!Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.D) && !Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Reverse", false);
            animator.SetBool("Forward", false);
            animator.SetBool("LeftTurn", false);
            animator.SetBool("RightTurn", false);
        }

        foreach (var wheel in m_Wheels)
        {
            if (wheel.transform.localPosition.z > 0)
                wheel.steerAngle = angle;

            if (wheel.transform.localPosition.z < 0)
                wheel.brakeTorque = handBrake;

            if (wheel.transform.localPosition.z < 0)
                wheel.motorTorque = torque;

            if (wheel.transform.localPosition.z >= 0)
                wheel.motorTorque = torque;
        }

        //rb.AddForce(new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed));
        //rb.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * (moveVertical * speed);
        //rb.velocity = transform.forward * (moveVertical * speed);
        //transform.Rotate(0, moveHorizontal, 0);
    }
}
using UnityEngine;

public class PlayerCameraBehaviour : MonoBehaviour
{
    public Transform playerToFollow;
    public float height;
    public float distance;

    public float smoother= 5.0f;
    public float rotationSmoother = 10.0f;
    public float bumperCameraHeight = 4.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per framedw
    void FixedUpdate()
    {
        //basic camera movement
        Vector3 wantedPosition = playerToFollow.TransformPoint(0, height, -distance);
        RaycastHit hit;

        //Checks to move camera for obsticles    
        Vector3 back = playerToFollow.transform.TransformDirection(-1 * Vector3.forward);
        if (Physics.Raycast(playerToFollow.TransformPoint(0, 1, 0), back, out hit, 2.5f)
            && hit.transform != playerToFollow)
        {
            wantedPosition = new Vector3(hit.point.x, Mathf.Lerp(hit.point.y + bumperCameraHeight, wantedPosition.y, Time.deltaTime * smoother), hit.point.z);
        }

        //fixes rotation and position of the camera
        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * smoother);
        Vector3 lookPosition = playerToFollow.TransformPoint(0, 0, 3);
        transform.rotation = Quaternion.LookRotation(lookPosition - transform.position, playerToFollow.up);
    }
}

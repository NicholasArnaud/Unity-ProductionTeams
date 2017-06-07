using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerCameraBehaviour : MonoBehaviour
{
    public GameObject PlayerToFollow;
    private Vector3 offset;
    private float nearClip;
    public float CameraDistance;
    private RaycastHit hit;
    // Use this for initialization
    void Start()
    {
        nearClip = GetComponent<Camera>().nearClipPlane;
        offset = transform.position - PlayerToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //basic camera movement         
        transform.forward = PlayerToFollow.transform.forward;
        transform.position = PlayerToFollow.transform.position - (transform.forward * CameraDistance) + new Vector3(0,5,0);
        

        //Checks to move nearClip for obsticles
        if (!Physics.Raycast(transform.position, Vector3.forward, out hit, 10))
        {
            nearClip = 0.3f;
        }
        else
        {
            var distance = hit.distance;
            var distanceToCenter = hit.collider.bounds.extents.z;
            nearClip = .3f + (distance + distanceToCenter * 2f);
        }
    }


    //Draws a line for the collision of the RayCast
    void OnDrawGizmos()
    {        
            Gizmos.DrawLine(transform.position, transform.forward * 2);
    }
}

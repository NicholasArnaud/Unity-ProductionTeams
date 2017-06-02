using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerCameraBehaviour : MonoBehaviour
{

    [Range(-45f, 45f)]
    public float CameraXRotation;
    [Range(-45f, 45f)]
    public float CameraYRotation;

    public GameObject PlayerToFollow;
    private Vector3 offset;
    private float nearClip;
    private RaycastHit hit;
    private float distanceBetween;

    // Use this for initialization
    void Start()
    {
        transform.rotation = Quaternion.Euler(CameraXRotation, CameraYRotation, 0);
        nearClip = GetComponent<Camera>().nearClipPlane;
        offset = transform.position - PlayerToFollow.transform.position;
        distanceBetween = Vector3.Distance(PlayerToFollow.transform.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerToFollow.transform.position + offset;
        transform.rotation = PlayerToFollow.transform.rotation;

        if (!Physics.Raycast(transform.position, Vector3.forward, out hit, PlayerToFollow.transform.position.z - transform.position.z))
        {
            if(nearClip != 0.3f)
                GetComponent<Camera>().nearClipPlane = 0.3f;
        }
        else
        {
            var distance = hit.distance;
            var distanceToCenter = hit.collider.bounds.extents.z;
            nearClip = .3f + (distance + distanceToCenter * 2f);
            GetComponent<Camera>().nearClipPlane = nearClip;
        }
    }

    void OnDrawGizmos()
    {
        if(hit.collider != null)
            Gizmos.DrawLine(transform.position, hit.transform.position);
    }
}

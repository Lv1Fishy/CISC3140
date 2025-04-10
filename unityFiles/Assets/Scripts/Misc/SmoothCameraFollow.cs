
/*
 *  This Script is attached to Camera Object
 *  Then attach the player object to the Transform target in the inspector
 *  The camera will follow the player object with a smooth transition
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour {
    [SerializeField] Vector3 offset; // The offset from the target position
    [SerializeField] float damping = 0.5f; // The speed of the camera movement
    public Transform target; // The target to follow
    private Vector3 vel = Vector3.zero; // The velocity of the camera

    void FixedUpdate(){
        Vector3 targetPos = target.position + offset; // The target position of the camera
        targetPos.z = transform.position.z; // Keep the camera's z position the same

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel, damping); // Smoothly move the camera to the target position
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    // Camera offset from target
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        // Follow the target
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * 3);
    }
}

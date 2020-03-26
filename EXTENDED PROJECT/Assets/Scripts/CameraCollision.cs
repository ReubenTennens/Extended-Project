﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{

    public float minDistance = 1.0f;
    public float maxDistance = 4.0f;
    public float smooth = 10.0f;
    Vector3 dollyDir;
    public Vector3 dollyDirAdjusted;
    public float distance;

    // Start is called before the first frame update
    void Awake()
    {
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredCameraPosition = transform.parent.TransformPoint(dollyDir * maxDistance);
        RaycastHit hit;
        Debug.DrawRay(transform.parent.position, desiredCameraPosition, Color.green);
        if (Physics.Linecast(transform.parent.position, desiredCameraPosition, out hit))
        {
            distance = Mathf.Clamp((hit.distance * 0.8f), minDistance, maxDistance);

        }
        else
        {
            distance = maxDistance;
        }

        // Changes camera position
        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, Time.deltaTime * smooth);
    }
}
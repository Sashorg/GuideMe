﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFollowCamera : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public float rotation;
    public Vector3 offset;
    

    
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(rotation, 180, 0));
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
       
        //transform.LookAt(target);
    }
    
}
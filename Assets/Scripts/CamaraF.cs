using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraF : MonoBehaviour
{
    public Transform target;
    public float rotar = 50;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public bool rotarCamara = false;

    void FixedUpdate()
    {
       
        if (Input.GetKey(KeyCode.S))
        {

            //transform.LookAt(target);

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

        if (Input.GetKey(KeyCode.A))
        {

            //transform.LookAt(target);

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

        if (Input.GetKey(KeyCode.D))
        {

            //transform.LookAt(target);

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTGEMI : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotar = 16;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * rotar * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.down * rotar * Time.deltaTime);
        }

    }
}

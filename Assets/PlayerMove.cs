﻿using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000;
    public float sideForce = 400;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Debug.Log("yikers");
        rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if(Input.GetKey("a")){
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

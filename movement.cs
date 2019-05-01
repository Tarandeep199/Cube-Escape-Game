using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{



    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsSpace = 0.000001f;





    // Start is caled before the first frame update

    void Start()
    {
        Debug.Log("okkk");

     

    }


    // Update is called once per frame
    //Use FixedUpdate vs just Update when dealing with physics aspects
    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //adds a forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upwardsSpace * Time.deltaTime,0, ForceMode.VelocityChange);
        }



    }
}

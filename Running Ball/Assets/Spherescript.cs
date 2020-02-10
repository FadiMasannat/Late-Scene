using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherescript : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sideFroce = 500f;
    private Vector3 startPos;
    
   
    // Start is called before the first frame update
    void Start()
    {
        startPos = rb.position; 

        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( Input.GetKey("d") )
        {
            rb.AddForce (sideFroce * Time.deltaTime , 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideFroce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
  

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("reset"))
        {
            rb.position = startPos;
        }

    }
}

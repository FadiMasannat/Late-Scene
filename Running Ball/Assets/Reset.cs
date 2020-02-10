using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Vector3 startPosition;
    public Rigidbody rb;

    void Awake()
    {
        startPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("q"))
        {
            transform.position = startPosition;
            
        }
    }
}

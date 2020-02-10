using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawn : MonoBehaviour
{

    public GameObject particleObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Instantiate(particleObject, transform.position, transform.rotation);

    }
}

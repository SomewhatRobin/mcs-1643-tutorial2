using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(-31.0f, 0f, -7.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

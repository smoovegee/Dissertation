using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foward : MonoBehaviour
{
   
    public Vector3 min;
    public Vector3 max;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(-4.225f, 0.013f, -11.779f);

       
    }

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, min.x, max.x),
            Mathf.Clamp(transform.position.y, min.x, max.y),
            Mathf.Clamp(transform.position.z, min.z, max.z));

    }
}
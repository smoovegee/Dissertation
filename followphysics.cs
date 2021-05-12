using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followphysics : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(target.transform.position);
    }
}

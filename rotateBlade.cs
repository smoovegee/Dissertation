using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBlade : MonoBehaviour
{
    public int speed; // we can change the speed value inside unity

    void Start()
    {

    }

    void Update()
    {

        transform.Rotate(0, speed, 0); //this will make the object spin on y axis for the speed value
    }
}

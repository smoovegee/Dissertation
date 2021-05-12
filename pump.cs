using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pump : MonoBehaviour
{

    private bool on = false;
    private bool pumpsHit = false;
    public GameObject pumps;

    private float pumpsOriginalY;
   // private float pumpsUpSpeed = 0.002f;
    public float pumpsDownDistance = 0.025f;

    //pump can be touched later

    private float pumpsHitAgainTime = 0.10f;
    private float canHitAgain;


    // Start is called before the first frame update
    void Start()
    {
        //get pump and position
        pumps = transform.gameObject;
        pumpsOriginalY = pumps.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (pumpsHit == true)
        {
            pumpsHit = false;
            //if on is true make on false, if on is false make on true
            on = !on;
            //change position
            pumps.transform.position = new Vector3(pumps.transform.position.x, pumps.transform.position.y - pumpsDownDistance, pumps.transform.position.z);



        }
    

    //return to original position
        if (pumps.transform.position.y < pumpsOriginalY)
        {
        pumps.transform.position += new Vector3(0, pumpsOriginalY, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("PlayerHand") && canHitAgain < Time.time)
         {
        canHitAgain = Time.time + pumpsHitAgainTime;
        pumpsHit = true;
         }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedChais : MonoBehaviour
{
    public GameObject Done;




    void OnTriggerEnter(Collider FinishedChais)
    {

        if (FinishedChais.gameObject.tag == "FinishedChais")
        {


            Done.SetActive(true);


            // Empty1.SetActive(false);
        }


    }
}

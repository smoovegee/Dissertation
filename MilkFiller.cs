using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkFiller : MonoBehaviour
{
    public GameObject Milk;
    public GameObject FrapRoast;
  
    void Start()
    {
        Milk.SetActive(false);
       // FillBlender.SetActive(false);
    }

    void OnTriggerEnter(Collider Milks)
    {
        if (Milks.gameObject.tag == "Milks")
        {
            Milk.SetActive(true);
            FrapRoast.SetActive(false);
        }
      
        Debug.Log("Barista poured milk");


    }

  




}

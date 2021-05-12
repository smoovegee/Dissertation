using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillScoop : MonoBehaviour
{
    public GameObject Ice;
    public GameObject Milk7;
    public GameObject Milk8;
    public GameObject Milk9;
    public GameObject Milk10;



    void Start()
    {
        Ice.SetActive(false);
     
    }

    void OnTriggerEnter(Collider Icecubes)
    {
        if (Icecubes.gameObject.tag == "Icecubes")
        {
            Ice.SetActive(true);
            
            Debug.Log("Barista scopped ice");
        }
            


    }
  

    void OnTriggerStay(Collider Blender)
    {
        if (Blender.gameObject.tag == "NonDairyBlender")
        {
            Ice.SetActive(false);
            Milk7.SetActive(true);
            Milk8.SetActive(false);
        }
        if (Blender.gameObject.tag == "SoyBlender")
        {
            Ice.SetActive(false);
           // Milk8.SetActive(true);
        }
        if (Blender.gameObject.tag == "DairyBlender")
        {
            Ice.SetActive(false);
            Milk9.SetActive(true);
            Milk10.SetActive(false);
        }


        Debug.Log("Barista dropped ice");


    }

}

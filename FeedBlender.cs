using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBlender : MonoBehaviour
{
    public GameObject Milky;
   // public GameObject MoreMilk;
    public GameObject LessMilk;
    public GameObject Dairy;
    

    void Start()
    {
        Milky.SetActive(false);
    
        LessMilk.SetActive(false);
        
      
    }

    void OnTriggerEnter(Collider Milks)
    {
        if (Milks.gameObject.tag == "Milks")
        {
            Milky.SetActive(false);
            Dairy.SetActive(false);

            LessMilk.SetActive(true);
        }
        
        
        Debug.Log("Barista poured milk into blender");


    }


    void OnTriggerStay(Collider Milks)
    {
        Milky.SetActive(false);
        Dairy.SetActive(false);
        LessMilk.SetActive(true);
         //LessMilk.SetActive(false);
        Debug.Log("Barista poured milk into cup");
    }
  
}

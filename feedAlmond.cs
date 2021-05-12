using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedAlmond : MonoBehaviour
{
    public GameObject AlmondMilks;
    public GameObject CoconutMilks;

    public GameObject LesserMilk;
  


 void Update()
    {
       // LesserMilk.SetActive(true);
    }

    void Start()
    {
        AlmondMilks.SetActive(false);
        
        LesserMilk.SetActive(false);
    }

    void OnTriggerEnter(Collider AlmondMilk)
    {
        if (AlmondMilk.gameObject.tag == "AlmondMilk")
        {
            AlmondMilks.SetActive(false);
            LesserMilk.SetActive(true);
            CoconutMilks.SetActive(false);
           
        }
        
        Debug.Log("Barista poured milk into blender");


    }
    void OnTriggerExit(Collider AlmondMilk)
    {
      
        Debug.Log("Barista poured milk into cup");
    }


}

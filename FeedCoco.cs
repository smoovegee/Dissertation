using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedCoco : MonoBehaviour
{
    public GameObject CoconutMilk;
   
    public GameObject LesserMilk;

    void Start()
    {
        CoconutMilk.SetActive(false);
        //   MoreMilk.SetActive(false);
        LesserMilk.SetActive(false);
    }

    void OnTriggerEnter(Collider CoconutMilks)
    {
        if (CoconutMilks.gameObject.tag == "CoconutMilks")
        {
            CoconutMilk.SetActive(false);
            // TakeMilk.SetActive(true);
            LesserMilk.SetActive(true);
        }
        Debug.Log("Barista poured milk into blender");


    }
    void OnTriggerExit(Collider CoconutMilks)
    {
        CoconutMilk.SetActive(false);
        Debug.Log("Barista poured milk into cup");
    }
    void OnTriggerStay(Collider Blender)
    {
        if (Blender.gameObject.tag == "Blender")
            CoconutMilk.SetActive(false);



    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedSoy : MonoBehaviour
{

    public GameObject SoyMilks;

    public GameObject LesserMilk;

    void Start()
    {
        SoyMilks.SetActive(false);

        LesserMilk.SetActive(false);
    }

    void OnTriggerEnter(Collider SoyMilk)
    {
        if (SoyMilk.gameObject.tag == "SoyMilk")
        {
            SoyMilks.SetActive(false);
            LesserMilk.SetActive(true);

        }

        Debug.Log("Barista poured milk into blender");


    }
    void OnTriggerExit(Collider SoyMilk)
    {
        SoyMilks.SetActive(false);
        Debug.Log("Barista poured milk into cup");
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmondMilkFiller : MonoBehaviour
{
    public GameObject AlmondMilks;

    void Start()
    {
        AlmondMilks.SetActive(false);
        // FillBlender.SetActive(false);
    }

    void OnTriggerEnter(Collider AlmondMilk)
    {
        if (AlmondMilk.gameObject.tag == "AlmondMilk")
            AlmondMilks.SetActive(true);

        Debug.Log("Barista poured milk");


    }


}

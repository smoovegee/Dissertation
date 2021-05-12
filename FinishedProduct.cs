using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedProduct : MonoBehaviour
{
    public GameObject Done;
    public GameObject Straw;
    public GameObject Almond;
    public GameObject SmallAlmond;
  



    void OnTriggerEnter(Collider FinishedProducts)
    {

        if (FinishedProducts.gameObject.tag == "FinishedProducts")
        {


            Done.SetActive(true);
            Straw.SetActive(false);
            Almond.SetActive(false);
            SmallAlmond.SetActive(false);

            // Empty1.SetActive(false);
        }


    }
}

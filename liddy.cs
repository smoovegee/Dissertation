using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liddy : MonoBehaviour
{
    public GameObject SnapLocation;
    public GameObject LidHolder;
    public GameObject blender;

    public bool isSnapped;

    private bool objectSnapped;

    private bool grabbed;

    void Start()
    {
        if (objectSnapped == false && grabbed == true)
        {
            this.transform.SetParent(LidHolder.transform);

            
        }
         objectSnapped = SnapLocation.GetComponent<BlenderLid>().Snapped;
    }
    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;


        objectSnapped = SnapLocation.GetComponent<BlenderLid>().Snapped;

        
        if (objectSnapped == true && grabbed == false)
                
        {
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.SetParent(SnapLocation.transform);
           // transform.SetParent(SnapLocation.transform);
            //transform.position = new Vector3(0, 1, 11);
            isSnapped = true;
        }
      
       
        /*if (objectSnapped == false && grabbed == false)
        {
            //this.transform.SetParent = null;
            transform.SetParent(null);
            GetComponent<Rigidbody>().isKinematic = false;
            
        }*/
      
    }
}

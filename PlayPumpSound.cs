using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPumpSound : MonoBehaviour
{
    public GameObject PumpSound;


    private void OnTriggerEnter()
    {
        PumpSound.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Obi;

public class LiquidPump : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    ObiEmitter emitter;
    public float emissionSpeed = 5;
   
    public GameObject Liquid;
    private bool _isPressed;
    public Vector3 _startPos;
    private ConfigurableJoint _joint;
    public UnityEvent onPressed, onReleased;
    public GameObject PumpSound;
    public bool PumpSounds;
    public GameObject Milk;
    
    //public GameObject Milks;

    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
       // Liquid.SetActive(false);

        emitter = GetComponentInChildren<ObiEmitter>();
        emissionSpeed = 0;
    }
    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
       
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
        
        _joint = GetComponent<ConfigurableJoint>();
        // emitter.speed = emissionSpeed;
    
    }
    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
        if (Mathf.Abs(value) < deadZone)
            value = 0;
        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        PumpSounds = true;
        _isPressed = true;
         onPressed.Invoke();
        PumpSound.SetActive(true);
        if (PumpSounds == true)
        {
             Liquid.SetActive(true);
            Milk.SetActive(false);
            
        }
       
        //fill.SetActive(true);
        emissionSpeed = 4;
        Debug.Log("button pressed");
        
    }

    private void Released()
    {
       
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("button released");
        emissionSpeed = 0;
      
    }
  
   private void OnTriggerEnter()
    {
        Liquid.SetActive(true);
    }    
   
}



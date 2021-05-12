using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    public Animation anim;
    private bool _isPressed;
    public Vector3 _startPos;
    private ConfigurableJoint _joint;
    public UnityEvent onPressed, onReleased;
    
    public AudioSource BlendSound;
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }
    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
    }
    private float GetValue()
    {
        var value  = Vector3.Distance( _startPos, transform.localPosition) / _joint.linearLimit.limit;
        if (Mathf.Abs(value) < deadZone)
            value = 0;
        return Mathf.Clamp(value,  -1f, 1f);
    }

    private void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
       // Liquid.SetActive(true); 
       // BlendSound.Play();
        Debug.Log("button pressed");
     
    }

    private void Released()
    {
        _isPressed = false;
        //Liquid.SetActive(false);
        onReleased.Invoke();
        Debug.Log("button released");
    }
    public void PlaySoundEffect()
    {
        BlendSound.Play();
    }

    void OnTriggerEnter(Collider BlenderBase)
    {
        if (_isPressed == true )
        {
            anim.Play();


        }


    }
}

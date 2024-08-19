using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class OutsideSpaceController : MonoBehaviour
{
    public XRLever lever;
    public XRKnob knob;
    public XRSlider slider;

    public float forwardSpeed;
    public float horizontalSpeed;
    public float verticalSpeed;


    // Update is called once per framed
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0);
        float horizontalVelocity = horizontalSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, knob.value);
        float verticalPosition = verticalSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, slider.value);

        Vector3 velocity = new Vector3(horizontalVelocity, 0, forwardVelocity);

        transform.position.Set(transform.position.x, verticalPosition, transform.position.z);
        transform.position += velocity * Time.deltaTime;
    }
}
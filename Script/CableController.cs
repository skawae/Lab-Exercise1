using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableController : MonoBehaviour
{
    public Transform trolley;   
    public Transform hook;      
    public LineRenderer cableRenderer;
    public float maxCableLength = 10f; // max of cable lengths 
    public float minCableLength = 2f;  // min of cable lengths

    private float cableLength;

    void Start()
    {

    }

    // Method to set the cable length depending on the slider value
    public void SetCableLength(float normalizedLength)
    {
        cableLength = Mathf.Lerp(minCableLength, maxCableLength, normalizedLength);

        // Update cable position by LineRenderer
        cableRenderer.SetPosition(0, trolley.position);
        cableRenderer.SetPosition(1, hook.position);

        // Update hook position
        hook.position = trolley.position - Vector3.up * cableLength;
    }

    void Update()
    {
        cableRenderer.SetPosition(0, trolley.position);
        cableRenderer.SetPosition(1, hook.position);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrolleyController : MonoBehaviour
{
    public Transform nearpoint; //point near from arms
    public Transform farpoint;  // point far from arms
    public float trolleyspeed = 5.0f;
    private float trolleyposition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetTrolleyPosition(float normalizedPosition)
    {
        trolleyposition = Mathf.Clamp(normalizedPosition, 0f, 1f);

        transform.position = Vector3.Lerp(nearpoint.position, farpoint.position, trolleyposition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SetTrolleyPosition(trolleyposition - trolleyspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            SetTrolleyPosition(trolleyposition + trolleyspeed * Time.deltaTime);
        }

        //// translate of trolley by slider
        //trolleyposition = Mathf.Clamp(trolleyposition + Input.GetAxis("Horizotal") * trolleyspeed * Time.deltaTime, 0f, 1f);
        //transform.position = Vector3.Lerp(nearpoint.position, farpoint.position, trolleyposition);
    }
}

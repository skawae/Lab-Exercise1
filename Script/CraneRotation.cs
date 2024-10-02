using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CraneRotation : MonoBehaviour
{
    public float rotationSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateCraneLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateCraneRight();
        }
    }

    public void RotateCraneLeft()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    public void RotateCraneRight()
    {
        transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
    }
}

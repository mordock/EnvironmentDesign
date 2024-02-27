using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWheel : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(rotateSpeed * Time.deltaTime, 0, 0), Space.Self);
    }
}

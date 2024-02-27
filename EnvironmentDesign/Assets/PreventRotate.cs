using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventRotate : MonoBehaviour
{
    private Vector3 startRotation;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.eulerAngles = startRotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWheelAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, transform.position.y - 10, 2f);
        LeanTween.moveX(gameObject, transform.position.x - 10, 2f);
        LeanTween.moveX(gameObject, transform.position.x - 10, 2f).setDelay(2.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

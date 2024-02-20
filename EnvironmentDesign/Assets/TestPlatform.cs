using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlatform : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E)) {
            transform.transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F)) {
            transform.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            other.gameObject.transform.SetParent(gameObject.transform);
            Debug.Log("Trigger");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            other.gameObject.transform.parent = null;
            Debug.Log("Exit");
        }
    }
}

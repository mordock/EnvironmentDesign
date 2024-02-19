using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool playerClose;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (playerClose) {
            if (Input.GetKeyDown(KeyCode.E)) {
                //progress game
                Debug.Log(gameObject.name);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            playerClose = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            playerClose = false;
        }
    }
}

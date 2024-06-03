using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLogic : MonoBehaviour
{
    public GameObject cam1, cam2, cam3, cam4;

    private int count = 0;
    // Start is called before the first frame update
    void Start() {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (count.Equals(0)) {
                cam1.SetActive(false);
                cam2.SetActive(true);
                count++;
            } else
            if (count.Equals(1)) {
                cam2.SetActive(false);
                cam3.SetActive(true);
                count++;
            } else
            if (count.Equals(2)) {
                cam3.SetActive(false);
                cam4.SetActive(true);
                count++;
            } else {
                count = 0;
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
            }
        }
    }
}

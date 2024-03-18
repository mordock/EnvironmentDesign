using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag.Equals("Player")) {
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<CheckPointManager>().LoadLatestCheckpoint(collision.gameObject);
        }
    }
}

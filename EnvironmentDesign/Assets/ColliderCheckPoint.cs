using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheckPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<CheckPointManager>().SetLatestCheckpoint(transform.parent.gameObject);
        }
    }
}

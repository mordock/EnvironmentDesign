using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWheelAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, transform.position.y - 10, 2f);
        LeanTween.moveX(gameObject, transform.position.x - 10, 2f).setOnComplete(MoveX);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveX() {
        LeanTween.moveX(gameObject, transform.position.x - 10, 2f).setOnComplete(Destroy);
    }

    void Destroy() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag.Equals("Player")) {
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<CheckPointManager>().LoadLatestCheckpoint(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollider : MonoBehaviour
{
    public enum ColliderType
    {
        Nothing,
        Spacebar,
        Shift
    }

    public ColliderType colliderType;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            if (colliderType.Equals(ColliderType.Spacebar)) {
                GameObject gameManager = GameObject.Find("GameManager");

                gameManager.GetComponent<TutorialManager>().SetSpaceBar();
            }else if (colliderType.Equals(ColliderType.Shift)) {
                GameObject gameManager = GameObject.Find("GameManager");

                gameManager.GetComponent<TutorialManager>().SetShift();
            }
        }
    }
}

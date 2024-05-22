using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject wasdObject;
    public GameObject eObject;
    public GameObject spaceObject;
    public GameObject shiftObject;

    public GameObject spacebarCollider;
    public float wasdTime;

    private float timer;
    private TutorialCollider.ColliderType colliderType = TutorialCollider.ColliderType.Nothing;
    // Start is called before the first frame update
    void Start()
    {
        wasdObject.SetActive(true);
        eObject.SetActive(false);
        spaceObject.SetActive(false);
        shiftObject.SetActive(false);

        LeanTween.scale(wasdObject, Vector3.one * 1.2f, 1f).setLoopPingPong();
        LeanTween.scale(eObject, Vector3.one * 1.2f, 1f).setLoopPingPong();
        LeanTween.scale(spaceObject, Vector3.one * 1.2f, 1f).setLoopPingPong();
        LeanTween.scale(shiftObject, Vector3.one * 1.2f, 1f).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > wasdTime) {
            if (colliderType.Equals(TutorialCollider.ColliderType.Spacebar)) {
                spaceObject.SetActive(false);
            }else if (colliderType.Equals(TutorialCollider.ColliderType.Shift)) {
                shiftObject.SetActive(false);
            } else {
                wasdObject.SetActive(false);
            }
            
        }
    }

    public void TriggerEObject(bool state) {
        eObject.SetActive(state);
    }

    public void SetSpaceBar() {
        colliderType = TutorialCollider.ColliderType.Spacebar;
        spaceObject.SetActive(true);
        timer = 0;
    }

    public void SetShift() {
        colliderType = TutorialCollider.ColliderType.Shift;
        shiftObject.SetActive(true);
        timer = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Animator animator;

    public Material offMaterial, onMaterial;

    public Color offColour, onColour;

    public List<GameObject> connnectedFires;
    public List<Light> connectedLights;

    public bool isLeftPuzzle;
    private bool playerClose;
    private bool pulled = false;

    // Start is called before the first frame update
    void Start() {
        var allMaterials = transform.GetChild(0).GetComponent<MeshRenderer>().materials;
        allMaterials[2] = offMaterial;
        transform.GetChild(0).GetComponent<MeshRenderer>().materials = allMaterials;

        foreach (GameObject flame in connnectedFires) {
            flame.transform.GetChild(1).gameObject.SetActive(false);
        }

        foreach (Light light in connectedLights) {
            light.color = offColour;
        }
    }

    // Update is called once per frame
    void Update() {
        if (playerClose && !pulled) {
            if (Input.GetKeyDown(KeyCode.E)) {
                animator.SetTrigger("Down");
                pulled = true;

                var allMaterials = transform.GetChild(0).GetComponent<MeshRenderer>().materials;
                allMaterials[2] = onMaterial;
                transform.GetChild(0).GetComponent<MeshRenderer>().materials = allMaterials;

                GameObject gameManager = GameObject.Find("GameManager");

                gameManager.GetComponent<PlayerManager>().Shake();

                foreach(GameObject flame in connnectedFires) {
                    flame.transform.GetChild(0).gameObject.SetActive(false);
                    flame.transform.GetChild(1).gameObject.SetActive(true);
                }

                foreach (Light light in connectedLights) {
                    light.color = onColour;
                }
                if (isLeftPuzzle) {
                    gameManager.GetComponent<LeftPuzzleCollapse>().Collapse();
                }

                gameManager.GetComponent<TutorialManager>().TriggerEObject(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            playerClose = true;
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<TutorialManager>().TriggerEObject(true);

        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag.Equals("Player")) {
            playerClose = false;
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<TutorialManager>().TriggerEObject(false);

        }
    }
}

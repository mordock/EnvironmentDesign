using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureManager : MonoBehaviour
{
    public int currentTreasureProgress = 0;
    public GameObject treasure;
    public List<GameObject> movePoints;
    public float moveSpeed;
    public GameObject treasureCamera;
    private bool moving;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (moving) {
            if (currentTreasureProgress.Equals(1)) {
                treasure.transform.position = Vector3.MoveTowards(treasure.transform.position, new Vector3(treasure.transform.position.x, movePoints[0].transform.position.y, treasure.transform.position.z), moveSpeed * Time.deltaTime);
            } else if (currentTreasureProgress.Equals(2)) {
                treasure.transform.position = Vector3.MoveTowards(treasure.transform.position, new Vector3(treasure.transform.position.x, movePoints[1].transform.position.y, treasure.transform.position.z), moveSpeed * Time.deltaTime);
            } else if (currentTreasureProgress.Equals(3)) {
                treasure.transform.position = Vector3.MoveTowards(treasure.transform.position, new Vector3(treasure.transform.position.x, movePoints[2].transform.position.y, treasure.transform.position.z), moveSpeed * Time.deltaTime);
            } else if (currentTreasureProgress.Equals(4)) {
                treasure.transform.position = Vector3.MoveTowards(treasure.transform.position, new Vector3(treasure.transform.position.x, movePoints[3].transform.position.y, treasure.transform.position.z), moveSpeed * Time.deltaTime);
            }
        }
        if (currentTreasureProgress.Equals(4)) {
            if (treasure.GetComponent<Treasure>().playerIsClose) {
                if (Input.GetKeyDown(KeyCode.E)){
                    SceneManager.LoadScene("MainMenuScene");
                }
            }
        }
    }

    public void ProgressTreasure() {
        currentTreasureProgress++;
        moving = true;
    }
}

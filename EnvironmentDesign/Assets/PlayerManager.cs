using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmoothShakeFree;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) {
            Shake();
        }
    }

    public void Die() {
        GetComponent<CheckPointManager>().LoadLatestCheckpoint(player);
    }

    public void Shake() {
        StartCoroutine(Wait(1));
    }

    IEnumerator Wait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        playerCamera.GetComponent<CinemachineBrain>().enabled = false;
        playerCamera.GetComponent<SmoothShake>().StartShake();
        yield return new WaitForSeconds(0.5f);
        playerCamera.GetComponent<CinemachineBrain>().enabled = true;
        GameObject gameManager = GameObject.Find("GameManager");

        gameManager.GetComponent<TreasureManager>().treasureCamera.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        gameManager.GetComponent<TreasureManager>().ProgressTreasure();

        yield return new WaitForSeconds(3);
        gameManager.GetComponent<TreasureManager>().treasureCamera.gameObject.SetActive(false);
    }
}

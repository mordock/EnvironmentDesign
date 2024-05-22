using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class CheckPointManager : MonoBehaviour
{
    public List<GameObject> checkpoints;

    private GameObject latestCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLatestCheckpoint(GameObject player) {
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponent<CharacterController>().enabled = false;
        player.GetComponent<BasicRigidBodyPush>().enabled = false;
        player.GetComponent<StarterAssetsInputs>().enabled = false;
        player.transform.position = latestCheckpoint.transform.GetChild(0).position;
        player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;
        player.GetComponent<BasicRigidBodyPush>().enabled = true;
        player.GetComponent<StarterAssetsInputs>().enabled = true;
    }

    public void SetLatestCheckpoint(GameObject checkpoint) {
        latestCheckpoint = checkpoint;
    }
}

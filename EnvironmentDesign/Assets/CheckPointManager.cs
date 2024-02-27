using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        player.transform.position = latestCheckpoint.transform.GetChild(0).position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPuzzleCollapse : MonoBehaviour
{
    public GameObject collapsedWalls;
    // Start is called before the first frame update
    void Start()
    {
        collapsedWalls.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collapse() {
        collapsedWalls.SetActive(true);
    }
}

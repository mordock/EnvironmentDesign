using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseObject;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseObject.SetActive(false);
        isPaused = false;
        UnPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!isPaused) {
                Pause();
            } else {
                UnPause();
            }
            
        }
    }

    public void Continue() {
        UnPause();
    }

    public void QuitToMain() {
        SceneManager.LoadScene("S_MainMenu");
    }

    private void UnPause() {
        pauseObject.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;

        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>().enabled = true;
        Cursor.visible = false;
    }

    private void Pause() {
        pauseObject.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;

        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>().enabled = false;
        Cursor.visible = true;
    }
}

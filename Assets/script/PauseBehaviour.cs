using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehaviour : MonoBehaviour
{
    //public GameObject GameUI;
    public GameObject PauseUI;
    public static bool inPause = false;

    void Start()
    {
        //PauseUI = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!inPause)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // GameUI.SetActive(false);
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        inPause = true;
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // GameUI.SetActive(true);
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        inPause = false;
    }

    public void BackMenu() 
    {
        ResumeGame();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        ResumeGame();
        SceneManager.LoadScene(1);
    }
}

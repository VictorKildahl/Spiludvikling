using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public bool gameIsPaused;

    public void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (gameIsPaused)
        //    {
        //        Resume();
        //    }
        //    else
        //    {
        //        Pause();
        //    }
        //}
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Home()
    {
        //  Time.timeScale = 1; 
        Time.timeScale = 0f;
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //  SceneManager.LoadScene(sceneID);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}

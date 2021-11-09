using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScript : MonoBehaviour
{
    public void Home()
    {
        //  Time.timeScale = 1; 
        Time.timeScale = 0f;
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //  SceneManager.LoadScene(sceneID);
        SceneManager.LoadScene("Victor", LoadSceneMode.Single);
    }


    public void QuitGame()
    {
        Application.Quit();
        // Debug.log("Quit");
    }
}

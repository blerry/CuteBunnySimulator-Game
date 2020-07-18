using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
}

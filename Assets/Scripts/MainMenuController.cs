using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }    
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGameListener()
    {
        Application.Quit();
    }

    public void OpenLink(string url)
    {
        print(url);
        Application.OpenURL(url);
    }
}

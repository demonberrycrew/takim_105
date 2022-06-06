using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;

    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.RedirectLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        SceneManager.LoadScene(4);
    }
}
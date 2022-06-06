using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOvery;
    public GameObject LevelAudio;
    public GameObject FadeOut;

    void OnTriggerEnter()
    {
        StartCoroutine(YouGameOver());
    }
    IEnumerator YouGameOver()
    {
        gameOvery.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.RedirectLevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;

    void OnTriggerEnter()
    {
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        totalScore.SetActive(true);
    }

}

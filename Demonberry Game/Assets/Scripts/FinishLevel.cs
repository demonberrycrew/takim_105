using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    void OnTriggerEnter()
    {
        timeCalc = GlobalTimer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time Left " + GlobalTimer.extendScore + " x 10";
        theScore.GetComponent<Text>().text = "Score " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score " + totalScored;
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
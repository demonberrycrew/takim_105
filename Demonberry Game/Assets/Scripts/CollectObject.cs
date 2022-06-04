using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
  
    public GameObject ScoreBox;
    public AudioSource CollectSound;

    void  OnTriggerEnter()
    {
        GlobalScore.currentScore += 100;
        Destroy(gameObject);
        CollectSound.Play();
    }
   
}

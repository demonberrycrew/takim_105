using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject fadeIn;

    // Start is called before the first frame update
    void Start()
    {
        RedirectToLevel.RedirectLevel = 3;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}

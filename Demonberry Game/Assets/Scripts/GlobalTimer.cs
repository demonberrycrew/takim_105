using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public bool isTakingTime = false;
    public int theSeconds = 100;
    public static int extendScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;

        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }

    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int RedirectLevel = 1;

    // Update is called once per frame
    void Update()
    {
        if(RedirectLevel == 1)
        {
            SceneManager.LoadScene(RedirectLevel);
        }
    }
}

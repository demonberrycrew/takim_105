using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int RedirectLevel;
    public static int nextLevel;

    // Update is called once per frame
    void Update()
    {
        if(RedirectLevel == 3)
        {
            SceneManager.LoadScene(RedirectLevel);
        }
    }
}

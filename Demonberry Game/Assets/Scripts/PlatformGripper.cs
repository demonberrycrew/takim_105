using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }
    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
        thePlayer.transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
}

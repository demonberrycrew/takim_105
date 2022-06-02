using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTransform : MonoBehaviour
{

    public float rotateSpeed = 0.67f;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}

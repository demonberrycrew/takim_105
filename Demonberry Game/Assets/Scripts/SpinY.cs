using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinY : MonoBehaviour
{
    public float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(0, speed, 0, Space.Self);
    }
}

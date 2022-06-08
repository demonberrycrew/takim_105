using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinNegative : MonoBehaviour

{
    public float speed = 0.08f;
// Start is called before the first frame update
void Start()
{

}


void Update()
{
    transform.Rotate(0, 0, -speed, Space.Self);
}
}
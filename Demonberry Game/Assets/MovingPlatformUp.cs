using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformRight: MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forceSpeed;


    public float time;
    public float interval;
    public bool timer;

    void Start()
    {
        forceSpeed = speed;
    }


    void Update()
    {
        rb.velocity = Vector3.right * forceSpeed;

        if (timer)
        {
            time += Time.deltaTime;
            if (time > interval)
            {

            }
            if (forceSpeed > 0)
            {
                forceSpeed = -speed;
                timer = false;
            }
            else if (forceSpeed < 0)
            {
                forceSpeed = speed;
                timer = false;
                time = 0;
            }





;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            timer = true;
        }



    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(this.rb.velocity.x, rb.velocity.y, this.rb.velocity.z); //OLMUYOR SEBEB?
        }
    }












}
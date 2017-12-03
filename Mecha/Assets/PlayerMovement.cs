using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform ts;
    public Vector3 x_offset;
    public Vector3 z_offset;
    public bool waitForMove;
    public bool first;
    public int timeToWait;
    public int tempTime;
    public float sidewaysForce = 500f;
    public float upwardsForce = 2000f;

	// Use this for initialization
	void Start () {
        waitForMove = false;
        timeToWait = 10;
        tempTime = 0;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!waitForMove)
        {
            if (Input.GetKey("w"))
            {
                ts.position = ts.position + z_offset;
                waitForMove = true;
            }
            if (Input.GetKey("s"))
            {
                ts.position = ts.position - z_offset;
                waitForMove = true;
            }
            if (Input.GetKey("d"))
            {
                ts.position = ts.position + x_offset;
                waitForMove = true;
            }
            if (Input.GetKey("a"))
            {
                ts.position = ts.position - x_offset;
                waitForMove = true;
            }
            tempTime = timeToWait;
        }
        else
        {
            tempTime = tempTime - 1;
            if (tempTime <= 0)
            {
                waitForMove = false;
                tempTime = timeToWait;
            }
        }
    }

    //Timer
    int Timer (int the_time)
    {
        while (the_time > 0)
        {
            the_time = the_time - 1;
        }
        return the_time;
    }
}

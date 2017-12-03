using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public Vector3 lastPosition;
    public float lastPositionX;
    public float lastPositionY;
    public float lastPositionZ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
        if (Input.mousePosition != lastPosition)
        {
            if (Input.mousePosition.x != lastPositionX)
            {

            }
            if (Input.mousePosition.y != lastPositionY)
            {

            }
            if (Input.mousePosition.z != lastPositionZ)
            {

            }
            lastPositionX = Input.mousePosition.x;
            lastPositionY = Input.mousePosition.y;
            lastPositionZ = Input.mousePosition.z;
            lastPosition = Input.mousePosition;
        }
    }
}

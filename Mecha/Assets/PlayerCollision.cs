﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : Enemy
{
    float timeStart = 0.0f;
    Player player;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    public void Start()
    {
        timeStart = Time.time;
        player = GameObject.FindObjectOfType<Player>();
        rigidBody = GetComponent<Rigidbody>();
    }

    public override void Behaviour()
    {
        transform.Translate(0.3f, 0.0f, 0.0f);

        // "Match Coordinates"
        if (player.transform.position.y > transform.position.y) {
            transform.Translate(0.0f, 0.05f, 0.0f);
        }
        if (player.transform.position.y < transform.position.y) {
            transform.Translate(0.0f, -0.05f, 0.0f);
        }

        if (player.transform.position.x > transform.position.x) {
            transform.Translate(0.05f, 0.0f, 0.0f);
        }
        if (player.transform.position.x < transform.position.x) {
            transform.Translate(-0.05f, 0.0f, 0.0f);
        }


    }
}

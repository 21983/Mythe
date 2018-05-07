﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerup : MonoBehaviour {

    private GameObject shieldedGameobject;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //shieldedGameobject = col.gameObject;
            //shieldedGameobject.GetComponent<Player1Controller>().stunned = true;
            col.gameObject.GetComponent<PlayerController>().shielded = true;
            Destroy(gameObject);
        }
    }
}

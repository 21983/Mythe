using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunTrap : MonoBehaviour
{

    private GameObject stunnedGameobject;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            stunnedGameobject = col.gameObject;
            stunnedGameobject.GetComponent<PlayerController>().stunned = true;
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPowerup : MonoBehaviour
{
    private GameObject[] Players;

    void Start()
    {
        if (Players == null)
            Players = GameObject.FindGameObjectsWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Players = GameObject.FindGameObjectsWithTag("Player");
            for (int i =0; i<Players.Length; i++)
            {
                GameObject player1 = Players[Random.Range(0, Players.Length)];
                GameObject player2 = Players[Random.Range(0, Players.Length)];
                Vector2 player1position = player1.transform.position;
                Vector2 player2position = player2.transform.position;
                player1.transform.position = player2position;
                player2.transform.position = player1position;
               
            }
            Destroy(gameObject);
        }
    }
}
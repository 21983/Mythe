using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    [SerializeField] private GameObject[] _players;

    private AddPlayers _joinGame;

    [SerializeField] private GameObject _getScripts;

	// Use this for initialization
	void Start () {

        _joinGame = _getScripts.GetComponent<AddPlayers>();

        for(int i = 0; i < _joinGame.currentPlayers; i++)
        {
            Instantiate(_players[i]);
        }
    }
}

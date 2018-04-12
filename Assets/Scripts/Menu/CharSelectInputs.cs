using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectInputs : MonoBehaviour {

    public JoinGame joinGame;

	// Use this for initialization
	void Start () {
        joinGame = GetComponent<JoinGame>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            joinGame.OnJoin();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            joinGame.OnLeave();
        }
    }
}

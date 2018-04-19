using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectInputs : MonoBehaviour
{
    //These 2 are from me, comment them out again when testing
    //Original code has the X + Z keycodes
    [SerializeField] KeyCode join;
    [SerializeField] KeyCode leave;

    public JoinGame joinGame;

    // Use this for initialization
    void Start()
    {
        joinGame = GetComponent<JoinGame>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.X))
        if (Input.GetKeyDown(join))
        {
            joinGame.OnJoin();
        }

        //if (Input.GetKeyDown(KeyCode.Z))
        if (Input.GetKeyDown(leave))
        {
            joinGame.OnLeave();
        }
    }
}


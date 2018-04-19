using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInputs : MonoBehaviour {

    public Pause pause;

    void Start()
    {
        pause = GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update () {
        //pause

        //PC
        if (Input.GetKeyDown(KeyCode.Escape) && !pause.isPaused)
        {
            pause.OnPause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && pause.isPaused)
        {
            pause.Resume();
        }

        //Testing the gameover screen
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause.OnGameOver();
        }

        //Controller
        //put here ur controller shit :3
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInputs : MonoBehaviour {

    public Pause pause;
    
    private bool _IsPaused;

    void Start()
    {
        pause = GetComponent<Pause>();
        _IsPaused = GetComponent<Pause>().isPaused;
    }

    // Update is called once per frame
    void Update () {
        _IsPaused = GetComponent<Pause>().isPaused;
        //pause
        if (Input.GetKeyDown(KeyCode.Escape) && !_IsPaused)
        {
            pause.OnPause();
        }else if(Input.GetKeyDown(KeyCode.Escape) && _IsPaused)
        {
            pause.Resume();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            pause.OnGameOver();
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInputs : MonoBehaviour {

    public Pause pause;
    private bool _IsPaused;

    [SerializeField] KeyCode pauseButton1;
    [SerializeField] KeyCode pauseButton2;
    [SerializeField] KeyCode pauseButton3;
    [SerializeField] KeyCode pauseButton4;

    void Start()
    {
        pause = GetComponent<Pause>();
        _IsPaused = GetComponent<Pause>().isPaused;
    }

    // Update is called once per frame
    void Update () {
        _IsPaused = GetComponent<Pause>().isPaused;
        //pause
        if (Input.GetKeyDown(pauseButton1) && !_IsPaused)
        {
            pause.OnPause();
        }
        else if (Input.GetKeyDown(pauseButton2) && !_IsPaused)
        {
            pause.OnPause();
        }
        else if (Input.GetKeyDown(pauseButton3) && !_IsPaused)
        {
            pause.OnPause();
        }
        else if (Input.GetKeyDown(pauseButton4) && !_IsPaused)
        {
            pause.OnPause();
        }
        else if(Input.GetKeyDown(pauseButton1) && _IsPaused)
        {
            pause.Resume();
        }
        else if (Input.GetKeyDown(pauseButton2) && _IsPaused)
        {
            pause.Resume();
        }
        else if (Input.GetKeyDown(pauseButton3) && _IsPaused)
        {
            pause.Resume();
        }
        else if (Input.GetKeyDown(pauseButton4) && _IsPaused)
        {
            pause.Resume();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            pause.OnGameOver();
        }
	}
}

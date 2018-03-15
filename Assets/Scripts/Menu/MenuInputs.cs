using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInputs : MonoBehaviour {

    private bool _IsPaused = false;
    public Pause pause;

    void Start()
    {
        pause = GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update () {

        //pause
        if (Input.GetKeyDown(KeyCode.Escape) && !_IsPaused)
        {
            _IsPaused = true;
            pause.OnPause();
        }else if(Input.GetKeyDown(KeyCode.Escape) && _IsPaused)
        {
            _IsPaused = false;
            pause.Resume();
        }
	}
}

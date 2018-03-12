using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    [SerializeField]
    private GameObject _pauseUI;

	// Use this for initialization
	void Start () {
        _pauseUI.SetActive(false);
	}
	
    public void OnPause()
    {
        Debug.Log("paused..");
        _pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

	public void Resume()
    {
        Debug.Log("unpause");
        _pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }
}

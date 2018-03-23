using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    [SerializeField]
    private GameObject _pauseUI;

    [SerializeField]
    private GameObject _gameOverUI;

    public bool isPaused = false;
    public bool isGameOver = false;

	// Use this for initialization
	void Start () {
        _pauseUI.SetActive(false);
        _gameOverUI.SetActive(false);
	}
	
    public void OnPause()
    {
        if (!isGameOver)
        {
            Debug.Log("paused..");
            _pauseUI.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

	public void Resume()
    {
        Debug.Log("unpause");
        _pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void OnGameOver()
    {
        if (!isPaused)
        {
            Debug.Log("game over..");
            _gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            isGameOver = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject[] _platforms;
    [SerializeField]
    private GameObject _leftWall;
    [SerializeField]
    private GameObject _rightWall;
    [SerializeField]
    private bool spawn = true;

    private float _timer;
    private Vector2 _spawnPosLeft;
    private Vector2 _spawnPosRight;
    [SerializeField] private int _yOffset = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        _side = Random.Range(0, 60);
        if((_side > 30 && _previousGameObject.transform.position.x < 7) || _previousGameObject.transform.position.x < -7)
        {
            _range = Random.Range(_previousGameObject.transform.position.x + 2, _previousGameObject.transform.position.x + 6);
        }
        else if((_side <= 30 && _previousGameObject.transform.position.x > -7) || _previousGameObject.transform.position.x > 7)
        {
            _range = Random.Range(_previousGameObject.transform.position.x - 6, _previousGameObject.transform.position.x - 2);
        }
        */
        if (spawn)
        {
            if (_timer <= 0)
            {
                _spawnPosLeft = new Vector2(Random.Range(_leftWall.transform.position.x, transform.position.x), transform.position.y + _yOffset);
                _spawnPosRight = new Vector2(Random.Range(transform.position.x, _rightWall.transform.position.x), transform.position.y + _yOffset);
                Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPosLeft, Quaternion.identity);
                Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPosRight, Quaternion.identity);

                _timer = Random.Range(1.5f, 2.5f);
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }
	}
}

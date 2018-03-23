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
    [SerializeField] private int _yOffset = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SpawnPlatform(Random.Range(_leftWall.transform.position.x, transform.position.x));
        SpawnPlatform(Random.Range(transform.position.x, _rightWall.transform.position.x));
	}
    private void SpawnPlatform(float spawnPosX)
    {
        if (spawn)
        {
            if (_timer <= 0)
            {
                Vector2 _spawnPos = new Vector2(spawnPosX, transform.position.y + _yOffset);
                Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPos, Quaternion.identity);
 

                _timer = Random.Range(2f, 3f);
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }
    }
}

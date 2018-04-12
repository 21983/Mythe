using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject[] _platforms;
    [SerializeField]
    private GameObject[] _traps;
    [SerializeField]
    private GameObject _leftWall;
    [SerializeField]
    private GameObject _rightWall;
    [SerializeField]
    private bool _spawn = true;
    [SerializeField]
    private GameObject previousObject;

    private float _timer;
    private float _trapTimer;
    [SerializeField]
    private float _yOffset = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SpawnPlatform(Random.Range(_leftWall.transform.position.x, transform.position.x), Random.Range(transform.position.x, _rightWall.transform.position.x));
        //SpawnPlatform(Random.Range(transform.position.x, _rightWall.transform.position.x));
        SpawnTrap();
	}
    private void SpawnPlatform(float spawnPosX, float spawnPosX2)
    {
        if (_spawn)
        {
            if (_timer <= 0)
            {
                Vector2 _spawnPos = new Vector2(spawnPosX, previousObject.transform.position.y + Random.Range(2f,5f));
                Vector2 _spawnPos2 = new Vector2(spawnPosX2, previousObject.transform.position.y + Random.Range(2f, 5f));
                previousObject = Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPos, Quaternion.identity);
                previousObject = Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPos2, Quaternion.identity);

                _timer = 3f;
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }
    }
    private void SpawnTrap()
    {
        if(_trapTimer <= 0)
        {
            _trapTimer = Random.Range(15, 20);
            int chooseSide = 1;

            chooseSide = Random.Range(-11, 10);
            Vector2 spawnPos;
            if (chooseSide >= 0)
            {
                spawnPos = new Vector2(_leftWall.transform.position.x, transform.position.y + _yOffset);
                Instantiate(_traps[Random.Range(0, _traps.Length)], spawnPos, Quaternion.Euler(new Vector3(0, 0, -180)));
            }
            else
            {
                spawnPos = new Vector2(_rightWall.transform.position.x, transform.position.y + _yOffset);
                Instantiate(_traps[Random.Range(0, _traps.Length)], spawnPos, Quaternion.identity);
            }
        }
        else
        {
            _trapTimer -= Time.deltaTime;
        }
    }
}

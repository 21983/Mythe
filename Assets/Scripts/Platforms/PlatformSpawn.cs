using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{

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
    private float height;
    [SerializeField]
    private float recondite = 4;

    private float _trapTimer;
    [SerializeField]
    private float _yOffset = 3f;

    // Update is called once per frame
    void Update()
    {
        SpawnPlatform(Random.Range(_leftWall.transform.position.x, transform.position.x), Random.Range(transform.position.x, _rightWall.transform.position.x));
        SpawnTrap();
    }

    private void SpawnPlatform(float spawnPosX, float spawnPosX2)
    {

        var d = Mathf.FloorToInt(transform.position.y/recondite);
        if (_spawn)
        {
            if (d > height)
            {
                height = d;
                Vector2 _spawnPos = new Vector2(spawnPosX, transform.position.y + Random.Range(7.5f, 10f));
                Vector2 _spawnPos2 = new Vector2(spawnPosX2, transform.position.y + Random.Range(7.5f, 10f));
                Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPos, Quaternion.identity);
                Instantiate(_platforms[Random.Range(0, _platforms.Length)], _spawnPos2, Quaternion.identity);
            }

        }
    }
    private void SpawnTrap()
    {
        if (_trapTimer <= 0)
        {
            _trapTimer = Random.Range(15, 20);
            int chooseSide;

            chooseSide = Random.Range(-11, 10);
            Vector2 spawnPos;

            Quaternion side = chooseSide >= 0 ? Quaternion.Euler(new Vector3(0, 0, -180)) : Quaternion.identity;

            spawnPos = new Vector2(_leftWall.transform.position.x, transform.position.y + _yOffset);
            Instantiate(_traps[Random.Range(0, _traps.Length)], spawnPos, side);
        }
        else
        {
            _trapTimer -= Time.deltaTime;
        }
    }
}

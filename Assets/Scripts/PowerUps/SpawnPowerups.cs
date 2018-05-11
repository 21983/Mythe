using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerups : MonoBehaviour {

    [SerializeField]
    private GameObject[] _Powerups;
    [SerializeField]
    private GameObject _leftWall;
    [SerializeField]
    private GameObject _rightWall;
    private float _yOffset = 6f;
    Timer t;
	// Use this for initialization
	void Start ()
    {
        t = Timer.StartNew(gameObject, Random.Range(5, 15), SpawnTimer);
    }
    
    private void SpawnTimer()
    {
        SpawnPowerup();
        Destroy(t);
        t = Timer.StartNew(gameObject, Random.Range(7, 17), SpawnTimer);
    }
    private void SpawnPowerup()
    {
        Vector2 _spawnPos = new Vector2(Random.Range(_leftWall.transform.position.x, _rightWall.transform.position.x), transform.position.y + _yOffset);
        Instantiate(_Powerups[Random.Range(0, _Powerups.Length)], _spawnPos, Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapShoot : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;

    private float _initialTimer = 3;
    private float _timer = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(_timer <= 0)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            _timer = _initialTimer;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
	}
}

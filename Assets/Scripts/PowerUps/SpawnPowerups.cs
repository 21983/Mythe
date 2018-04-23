using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerups : MonoBehaviour {

    Timer t;
	// Use this for initialization
	void Start ()
    {
        t = Timer.StartNew(gameObject, Random.Range(0, 2000), SpawnPowerUp);
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    private void SpawnPowerUp()
    {
        Destroy(t);
        t = Timer.StartNew(gameObject, Random.Range(3, 10), SpawnPowerUp);
        //Instantiate();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 10;
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.right * speed * Time.deltaTime;
	}
}

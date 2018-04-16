using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    private float _speed = 10;
    private float thrust = 5;

    // Update is called once per frame
    void Update () {
        transform.position -= transform.right * _speed * Time.deltaTime;
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Triggered");
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * thrust, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
    }
}

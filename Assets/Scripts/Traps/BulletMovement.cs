using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    private float _speed = 10;
    private float thrust = 5;
    Timer t;
    void Update () {
        transform.position -= transform.right * _speed * Time.deltaTime;
        if (t == null)
            t = Timer.StartNew(gameObject, 2.5f, DestroyBullet);
    }
    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Triggered");
        if (col.gameObject.tag == "Player")
        {
            if(!col.GetComponent<PlayerController>().shielded)
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * thrust, ForceMode2D.Impulse);

            Destroy(gameObject);
        }
    }
}

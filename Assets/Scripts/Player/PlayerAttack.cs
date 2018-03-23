using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField]
    private float thrust = 5;
    private bool isLeft;

    private bool isTriggered = false;
    private GameObject enemy;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.parent.position - new Vector3(GetComponent<BoxCollider2D>().size.x/2 + 0.11f, 0, 0);
            isLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.parent.position + new Vector3(GetComponent<BoxCollider2D>().size.x / 2 + 0.11f, 0, 0);
            isLeft = false;
        }

        Attack(KeyCode.Space);
    }
    public void Attack(KeyCode Key)
    {
        if (Input.GetKeyDown(Key) && isTriggered)
        {
            Debug.Log("Slang");
            if (isLeft)
            {
                enemy.gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * thrust, ForceMode2D.Impulse);
            }
            else
            {
                enemy.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * thrust, ForceMode2D.Impulse);
            }
        }
    }


    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Moan");
           if (col.gameObject.tag == "Player")
           {
                isTriggered = true;
                enemy = col.gameObject;
                Debug.Log(enemy);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTriggered = false;
        }
    }
}

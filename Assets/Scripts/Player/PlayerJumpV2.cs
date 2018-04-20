using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpV2 : MonoBehaviour {

    private float jumpForce = 20f;
    private bool jumpHold = false;
    private float maxJumpHeight = 10f;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpHold = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpHold = false;
        }

        if (jumpHold)
        {
            Jump();
        }

	}

    public void Jump()
    {
        Debug.Log("jump");


        rb.AddForce(transform.up * jumpForce);
    }
}

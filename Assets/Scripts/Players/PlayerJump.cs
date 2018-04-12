using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {
    [SerializeField]
    float jumpForce;

    [SerializeField]
    private Transform groundCheckPoint;
    [SerializeField]
    private float groundCheckRadius;
    [SerializeField]
    private LayerMask groundLayer;

    private Rigidbody2D rB;

    private bool isGrounded;

    void Start () {
        rB = GetComponent<Rigidbody2D>();
    }

    public void Jump(KeyCode Key)
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        if (Input.GetKeyDown(Key) && isGrounded)
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpForce);
        }
    }
}

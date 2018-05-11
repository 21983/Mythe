using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Controller : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    [SerializeField] KeyCode jump;

    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rB;

    private bool isGrounded;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);

        float translation = Input.GetAxis("LeftJoystickX_P3") * moveSpeed;
        translation *= Time.deltaTime;
        transform.position += new Vector3(translation, 0, 0);

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpForce);
        }
    }
}

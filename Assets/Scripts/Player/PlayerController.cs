using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    [SerializeField] KeyCode left;
    [SerializeField] KeyCode right;
    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode useItem;

    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rB;

    private bool isGrounded;


    void Start ()
    {
        rB = GetComponent<Rigidbody2D>();
    }

	private void Update()
	{
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);

        if(Input.GetKey(left))
        {
            rB.velocity = new Vector2(-moveSpeed, rB.velocity.y);
        } 
        else if(Input.GetKey(right))
        {
            rB.velocity = new Vector2(moveSpeed, rB.velocity.y);
        } 
        else 
        {
            rB.velocity = new Vector2(0, rB.velocity.y);
        }

        if(Input.GetKeyDown(jump) && isGrounded)
        {
            rB.velocity = new Vector2(rB.velocity.x, jumpForce);
        }
	}
}
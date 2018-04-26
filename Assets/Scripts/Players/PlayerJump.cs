using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;
    [SerializeField]
    private Transform _groundCheckPoint;
    [SerializeField]
    private float _groundCheckRadius;
    [SerializeField]
    private LayerMask _groundLayer;

    private Rigidbody2D _rB;

    private bool _isGrounded;

    void Start()
    {
        _rB = GetComponent<Rigidbody2D>();
    }

    public void Jump(KeyCode Key)
    {   
        
        //float fallMultiplier = 2f;
        //float lowJumpMultiplier = 1.5f;
        _isGrounded = Physics2D.OverlapCircle(_groundCheckPoint.position, _groundCheckRadius, _groundLayer);
        if (Input.GetKeyDown(Key) && _isGrounded)
        {


            _rB.velocity = new Vector2(_rB.velocity.x, _jumpForce); //Vector2.up * _jumpForce;
            //_rB.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

        }
        /*
        if (_rB.velocity.y < 0)
        {
            Debug.Log(_rB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime);
            _rB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (_rB.velocity.y > 0 && !Input.GetKeyDown(Key))
        {
            Debug.Log(_rB.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime);
            _rB.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        */
    }
}
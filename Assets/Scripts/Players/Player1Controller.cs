using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField]
    private float translation;
    [SerializeField]
    private string _Joystick;
    [SerializeField]
    float moveSpeed;
    private PlayerAttack _playerAttack;
    private PlayerJump _playerJump;
    [SerializeField]
    KeyCode jump;
    [SerializeField]
    KeyCode punch;
    public bool stunned;
    Timer t;
    private void Start()
    {
        _playerAttack = GetComponent<PlayerAttack>();
        _playerJump = GetComponent<PlayerJump>();
    }

    private void Update()
    {
        if (!stunned)
        {
            //float translation = Input.GetAxis(_Joystick) * moveSpeed;
            float translation = Input.GetAxis("Horizontal") * moveSpeed;
            if (translation < 0)
            {
                _playerAttack.ChangeHitbox("left");
            }
            else if (translation > 0)
            {
                _playerAttack.ChangeHitbox("right");
            }

            translation *= Time.deltaTime;
            transform.position += new Vector3(translation, 0, 0);

            _playerJump.Jump(jump);
            _playerAttack.Attack(punch);
        }
        if (stunned)
        {
            if(t == null)
                t = Timer.StartNew(gameObject, 1f, ChangeStun);
        }
    }
    private void ChangeStun()
    {
        stunned = !stunned;
        Destroy(t);
    }
}
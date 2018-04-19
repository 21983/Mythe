/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField] private string Joystick;
    [SerializeField] float moveSpeed;
    private PlayerAttack _playerAttack;
    private float translation;
    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode punch;
    public bool stunned;

    private void Start()
    {
        _playerAttack = GetComponent<PlayerAttack>();
    }

    private void Update()
    {
        float translation = Input.GetAxis("LeftJoystickX_P1") * moveSpeed;
        //float translation = Input.GetAxis("Horizontal") * moveSpeed;
        if (translation < 0)
        {
            gameObject.GetComponent<PlayerAttack>().ChangeHitbox("left");
        }
        else if (translation > 0)
        {
            if (!stunned)
            {
                float translation = Input.GetAxis(Joystick) * moveSpeed;
                //float translation = Input.GetAxis("Horizontal") * moveSpeed;
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

                gameObject.GetComponent<PlayerJump>().Jump(jump);
                _playerAttack.Attack(punch);
            }
        }
    }
}
*/
/*using System.Collections;
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
<<<<<<< HEAD
    private float translation;
    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode punch;
    public bool stunned;

=======
    private PlayerJump _playerJump;
    [SerializeField]
    KeyCode jump;
    [SerializeField]
    KeyCode punch;
    public bool stunned;
    Timer t;
>>>>>>> 1e8a58cefeefbb8c503879af2036e5de1ed0769b
    private void Start()
    {
        _playerAttack = GetComponent<PlayerAttack>();
        _playerJump = GetComponent<PlayerJump>();
    }

    private void Update()
    {
        float translation = Input.GetAxis("LeftJoystickX_P1") * moveSpeed;
        //float translation = Input.GetAxis("Horizontal") * moveSpeed;
        if (translation < 0)
        {
<<<<<<< HEAD
            gameObject.GetComponent<PlayerAttack>().ChangeHitbox("left");
        }
        else if (translation > 0)
        {
            if (!stunned)
=======
            //float translation = Input.GetAxis(_Joystick) * moveSpeed;
            translation = Input.GetAxis("Horizontal") * moveSpeed;
            if (translation < 0)
            {
                _playerAttack.ChangeHitbox("left");
            }
            else if (translation > 0)
>>>>>>> 1e8a58cefeefbb8c503879af2036e5de1ed0769b
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

<<<<<<< HEAD
                gameObject.GetComponent<PlayerJump>().Jump(jump);
                _playerAttack.Attack(punch);
            }
=======
            _playerJump.Jump(jump);
            _playerAttack.Attack(punch);
>>>>>>> 1e8a58cefeefbb8c503879af2036e5de1ed0769b
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
<<<<<<< HEAD
}
*/
=======
}
>>>>>>> 1e8a58cefeefbb8c503879af2036e5de1ed0769b

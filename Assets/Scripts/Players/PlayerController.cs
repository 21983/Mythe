using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float translation;
    [SerializeField] private string _Joystick;
    [SerializeField] float moveSpeed;
    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode punch;

    private PlayerAttack _playerAttack;
    private PlayerJump _playerJump;

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
            translation = Input.GetAxis(_Joystick) * moveSpeed;
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
            if (t == null)
                t = Timer.StartNew(gameObject, 1f, ChangeStun);
        }
    }

    private void ChangeStun()
    {
        stunned = !stunned;
        Destroy(t);
    }
}
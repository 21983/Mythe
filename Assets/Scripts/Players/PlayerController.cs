using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float translation;
    [SerializeField]
    private string _joystick;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    private GameObject shield;
    private PlayerAttack _playerAttack;
    private PlayerJump _playerJump;
    [SerializeField]
    KeyCode jump, punch;
    public bool stunned, shielded;
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
            translation = Input.GetAxis(_joystick) * moveSpeed;
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
        if (shielded)
        {
            if (t == null)
            {
                shield = Instantiate(shield, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                t = Timer.StartNew(gameObject, 5f, ChangeShielded);
            }

            shield.transform.position = transform.position;
        }
    }

    private void ChangeStun()
    {
        stunned = !stunned;
        Destroy(t);
    }
    private void ChangeShielded()
    {
        shielded = !shielded;
        Destroy(shield);
        Destroy(t);
    }
    public void GetKnockback(Vector3 dir, float k)
    {
        if (!shielded)
            gameObject.GetComponent<Rigidbody2D>().AddForce(dir * k, ForceMode2D.Impulse);
    }
}

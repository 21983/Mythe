using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    [SerializeField] KeyCode jump;
    [SerializeField] KeyCode punch;

    private void Update()
    { 
        //float translation = Input.GetAxis("LeftJoystickX_P1") * moveSpeed;
        float translation = Input.GetAxis("Horizontal") * moveSpeed;
        if(translation < 0)
        {
            gameObject.GetComponent<PlayerAttack>().ChangeHitbox("left");
        }
        else if(translation > 0)
        {
            gameObject.GetComponent<PlayerAttack>().ChangeHitbox("right");
        }

        translation *= Time.deltaTime;
        transform.position += new Vector3(translation, 0, 0);

        gameObject.GetComponent<PlayerJump>().Jump(jump);
        gameObject.GetComponent<PlayerAttack>().Attack(punch);
    }
}

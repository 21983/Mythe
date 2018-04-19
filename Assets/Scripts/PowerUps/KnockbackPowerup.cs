using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackPowerup : MonoBehaviour {

    private bool pickedUp;
    private GameObject player;
    [SerializeField]
    private float knockback = 5;
    Timer t;

    private void Update()
    {
        if (pickedUp && player != null)
        {
            transform.position = player.transform.position;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !pickedUp)
        {
            pickedUp = true;
            player = col.gameObject;
            player.GetComponent<PlayerAttack>().knockback = knockback;
            if (t == null)
                t = Timer.StartNew(gameObject, 5f, DestroyItem);
        }
    }
    private void DestroyItem()
    {
        player.GetComponent<PlayerAttack>().knockback = player.GetComponent<PlayerAttack>().initialKnockback;
        Destroy(gameObject);
    }

}

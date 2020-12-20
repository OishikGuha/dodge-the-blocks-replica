using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public LostMenu LostScript;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<SoundManager>().Play("Player Lose");
            LostScript.isOn = true;
        }
    }
}

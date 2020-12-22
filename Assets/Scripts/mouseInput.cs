using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseInput : MonoBehaviour
{

    private PlayerMovement player;

    private Rigidbody2D rb;

    private float mapWidth;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerMovement>();
        rb = player.GetComponent<Rigidbody2D>();
        mapWidth = player.mapWidth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 x = Input.mousePosition;
        x = Camera.main.ScreenToWorldPoint(x);

        x.x = Mathf.Clamp(x.x, -mapWidth, mapWidth);

        rb.MovePosition(x);
    }
}

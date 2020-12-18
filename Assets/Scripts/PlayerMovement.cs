using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float mapWidth = 5f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 x = Input.mousePosition;
        x = Camera.main.ScreenToWorldPoint(x);

        x.x = Mathf.Clamp(x.x, -mapWidth, mapWidth);

        rb.MovePosition(x);

    }

}

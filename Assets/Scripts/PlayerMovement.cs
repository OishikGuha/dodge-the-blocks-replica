using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float mapWidth = 5f;
    public float speed = 10f;

    private bool switchKey = false;

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
        //mouse Input
        Vector2 x = Input.mousePosition;
        x = Camera.main.ScreenToWorldPoint(x);

        float xKey = Input.GetAxis("Horizontal");

        x.x = Mathf.Clamp(x.x, -mapWidth, mapWidth);
        xKey = Mathf.Clamp(x.x, -mapWidth, mapWidth);

        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log(switchKey);
            switchKey = true;
        }
        else if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log(switchKey);
            switchKey = false;
        }

        if (switchKey)
        {
            rb.MovePosition(new Vector2(xKey * speed * Time.deltaTime, 0f));
        }
        else
        {
            rb.MovePosition(x);
        }
    }

}

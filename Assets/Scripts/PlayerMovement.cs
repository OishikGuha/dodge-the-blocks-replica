using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 20f;
    public float mapWidth = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 newPos = rb.position + Vector2.right * x * speed * Time.deltaTime;

        newPos.x = Mathf.Clamp(newPos.x, -mapWidth, mapWidth);

        rb.MovePosition(newPos);   

    }

}

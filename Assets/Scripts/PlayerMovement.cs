using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject mouseInput;
    public GameObject keyInput;

    public float mapWidth = 5f;
    public float speed = 10f;

    public static bool switchKey = true;

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
        if (switchKey)
        {
            mouseInput.SetActive(true);
            keyInput.SetActive(false);
        }
        else
        {
            mouseInput.SetActive(false);
            keyInput.SetActive(true);
        }
    }
}

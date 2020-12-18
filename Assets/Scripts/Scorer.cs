using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    public float scoreMultiplier = 1f;

    private float target;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        target += scoreMultiplier;

        rb.MovePosition(new Vector2(target, 0f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [Range(0f, 100f)]
    public float scoreMultiplier = 1f;

    private float target;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target += 1;
    }

    // Update is called once per frame
    void Update()
    {

        target += scoreMultiplier;

        rb.MovePosition(new Vector2(target, 0f));
    }

    public void setMult(float num)
    {
        scoreMultiplier = num;
        Debug.Log(scoreMultiplier);
    }
}

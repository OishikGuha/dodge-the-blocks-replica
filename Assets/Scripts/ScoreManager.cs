using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    
    private float score;

    private Text text;

    public Transform scorer;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score = scorer.position.x;
        text.text = string.Format("Score: {0}", score.ToString("0   "));  
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }   

}

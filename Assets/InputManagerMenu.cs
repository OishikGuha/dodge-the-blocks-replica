using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManagerMenu : MonoBehaviour
{

    public PlayerMovement player;

    private GameObject mouse;
    private GameObject keyboard;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerMovement.switchKey)
        {
            text.text = "Mouse";
        }
        else
        {
            text.text = "Keyboard";
        }

    }

    public void Mouse()
    {
        PlayerMovement.switchKey = true;
    }

    public void Keyboard()
    {
        PlayerMovement.switchKey = false;
    }
}

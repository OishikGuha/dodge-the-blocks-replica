using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public LevelLoader loader;
    public GameObject transition;

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextLevel()
    {
        transition.SetActive(true);
        loader.SwitchLevel();
    }

    public void Quit()
    {
        Application.Quit();
    }
}

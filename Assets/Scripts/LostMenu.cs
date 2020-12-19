using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LostMenu : MonoBehaviour
{

    public GameObject lostMenuUI;

    [HideInInspector]
    public bool isOn = false;

    void Update()
    {
        if (isOn)
        {
            lostMenuUI.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        LoadNext();
    }

    void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mainUI;
    public void StartGame()
    {
        mainMenu.SetActive(false);
        mainUI.SetActive(true);
        Debug.Log("can press Button");
    }
    public void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        mainMenu.SetActive(true);
        mainUI.SetActive(false);
    }
}

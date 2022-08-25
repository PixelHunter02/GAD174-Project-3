using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mainUI;
    public AudioSource cupboard;
    private bool mainMenuOpen = true;
    public void StartGame()
    {
        mainMenu.SetActive(false);
        mainUI.SetActive(true);
        Debug.Log("can press Button");
        mainMenuOpen = false;
    }
    public void Update()
    {
        if (!mainMenuOpen)
        {
            if (Input.GetKeyDown("p"))
            {
                PauseGame();
                mainMenuOpen = true;
            }
            if (Input.GetKeyDown("e"))
            {
                cupboard.Play();
            }
        }
    }
    public void PauseGame()
    {
        mainMenu.SetActive(true);
        mainUI.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mainUI;
    public AudioSource cupboard;
    [SerializeField]
    GameObject camera;
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
        if(Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit, 100)) 
            {
                if(hit.transform.tag == "Left Cupboard Door")
                {
                    if(hit.transform.GetComponent<Animator>().GetBool("Left Door Open") == false)
                    {
                        hit.transform.GetComponent<Animator>().SetBool("Left Door Open", true);
                    }
                    else
                    {
                        hit.transform.GetComponent<Animator>().SetBool("Left Door Open", false);
                    }
                    
                }
            }
        }

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

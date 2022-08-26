using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mainUI;
    public AudioSource cupboard;
    [SerializeField]
    private bool mainMenuOpen = true;
    [SerializeField]
    Slider slider;
    [SerializeField]
    AudioClip[] audioClips;

    public void Start()
    {
        MainMenu();
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
                        gameObject.GetComponent<AudioSource>().clip = audioClips[0];
                        cupboard.Play();
                    }
                    else if(hit.transform.GetComponent<Animator>().GetBool("Left Door Open") == true)
                    {
                        hit.transform.GetComponent<Animator>().SetBool("Left Door Open", false);
                        gameObject.GetComponent<AudioSource>().clip = audioClips[0];
                        cupboard.Play();
                    }
                    else
                    {
                    gameObject.GetComponent<AudioSource>().clip = audioClips[1];
                    gameObject.GetComponent<AudioSource>().Play();
                    }
                    
                }

                else if(hit.transform.tag == "Right Cupboard Door")
                {
                    if(hit.transform.GetComponent<Animator>().GetBool("Right Door Open") == false)
                    {
                        hit.transform.GetComponent<Animator>().SetBool("Right Door Open", true);
                        gameObject.GetComponent<AudioSource>().clip = audioClips[0];
                        cupboard.Play();
                    }
                    else if(hit.transform.GetComponent<Animator>().GetBool("Right Door Open") == true)
                    {
                        hit.transform.GetComponent<Animator>().SetBool("Right Door Open", false);
                        gameObject.GetComponent<AudioSource>().clip = audioClips[0];
                        cupboard.Play();
                    }
                    else
                    {
                    gameObject.GetComponent<AudioSource>().clip = audioClips[1];
                    gameObject.GetComponent<AudioSource>().Play();
                    }
                }

                else if(hit.transform.tag == "Lego")
                {
                    Destroy(hit.transform.gameObject);
                    slider.value += 0.1428f;
                }
                else if(hit.transform.tag == "Book")
                {
                    Destroy(hit.transform.gameObject);
                    slider.value += 0.1428f;
                }
                else if(hit.transform.tag == "Sword")
                {
                    Destroy(hit.transform.gameObject);
                    slider.value += 0.1428f;
                }
                else if(hit.transform.tag == "Plushie")
                {
                    Destroy(hit.transform.gameObject);
                    slider.value += 0.1428f;
                }
                else
                {
                    gameObject.GetComponent<AudioSource>().clip = audioClips[1];
                    gameObject.GetComponent<AudioSource>().Play();
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
        }
    }
    public void MainMenu()
    {
        mainMenuOpen = true;
        mainMenu.SetActive(true);
        mainUI.SetActive(false);
        this.GetComponent<Timer>().timer = 60f;
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        mainMenuOpen = false;
        slider.value = 0f;
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        mainUI.SetActive(true);
    }

    public void PauseGame()
    {
        mainMenuOpen = true;    
        mainMenu.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0;
    }
}

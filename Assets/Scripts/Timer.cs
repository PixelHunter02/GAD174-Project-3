using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timer = 60f;
    [SerializeField]
    Slider slider;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        slider.value = timer;
        if(timer <= 0f)
        {
            SceneManager.LoadScene("Main");
        }
    }
}

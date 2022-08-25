using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    Slider slider;
    [SerializeField]
    GameObject fillColour;
    [SerializeField]
    Image emote;
    [SerializeField]
    Sprite[] images;
    // Start is called before the first frame update
    void Start()
    {
        slider  = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value < 0)
        {
            slider.value = 0;
            emote.sprite = images[0];
        }
        if(slider.value <= 0.14f)
        {
            fillColour.GetComponent<Image>().color = new Color32(255,0,0,148);
            emote.sprite = images[0];
        }
        if(slider.value >=0.141f && slider.value <= 0.28f)
        {
            fillColour.GetComponent<Image>().color = new Color32(241,134,5,148);
            emote.sprite = images[1];
        }
        if(slider.value >=0.281f && slider.value <= 0.42f)
        {
            fillColour.GetComponent<Image>().color = new Color32(241,255,0,148);
            emote.sprite = images[1];
        }
        if(slider.value >=0.421f && slider.value <= 0.56f)
        {
            fillColour.GetComponent<Image>().color = new Color32(199,255,0,148);
            emote.sprite = images[2];
        }
        if(slider.value >=0.561f && slider.value <= 0.70f)
        {
            fillColour.GetComponent<Image>().color = new Color32(150,255,5,148);
            emote.sprite = images[3];
        }
        if(slider.value >=0.71f && slider.value <= 0.84f)
        {
            fillColour.GetComponent<Image>().color = new Color32(68,255,0,148);
            emote.sprite = images[3];
        }
        if(slider.value >=0.841f)
        {
            fillColour.GetComponent<Image>().color = new Color32(0,255,0,148);
            emote.sprite = images[4];
        }
    }
}

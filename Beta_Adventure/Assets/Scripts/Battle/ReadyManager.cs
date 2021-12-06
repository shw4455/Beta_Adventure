using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyManager : MonoBehaviour
{
    public AudioClip readyClip;
    public AudioSource audio;
    private int Timer = 0;
    public GameObject Ready_img;
    public GameObject Set_img;
    public GameObject Go_img;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer == 0)
        {
            audio.PlayOneShot(readyClip);
            Time.timeScale = 0.0f;
        }
        if (Timer <= 3000)
        {
            
            Timer++;
            Ready_img.SetActive(true);
            if (Timer > 1000)
            {
                Ready_img.SetActive(false);
                Set_img.SetActive(true);
            }
            if (Timer > 2000)
            {
                Set_img.SetActive(false);
                Go_img.SetActive(true);
            }
            if (Timer >= 3000)
            {
                Go_img.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }
}

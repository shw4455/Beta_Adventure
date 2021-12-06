using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_DungenCanvas : MonoBehaviour
{
    public GameObject Modcanvas;
    public GameObject Storycanvas;
    public GameObject Chap1canvas;
    public GameObject Chap2canvas;

    public void Strbutton()
    {
        Modcanvas.SetActive(false);
        Storycanvas.SetActive(true);
        Chap1canvas.SetActive(false);
        Chap2canvas.SetActive(false);
    }
    public void Chap1button()
    {
        Modcanvas.SetActive(false);
        Storycanvas.SetActive(false);
        Chap1canvas.SetActive(true);
        Chap2canvas.SetActive(false);
    }
    public void Chap2Button()
    {
        Modcanvas.SetActive(false);
        Storycanvas.SetActive(false);
        Chap1canvas.SetActive(false);
        Chap2canvas.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager_MainScene : MonoBehaviour
{
    public GameObject maincanvas;
    public GameObject Duncanvas;
    public GameObject Shopcanvas;
    public GameObject Modcanvas;
    public Image mainbtn;
    public Image Dunbtn;
    public Image Shopbtn;

    public GameObject TranslucentLayer;
    public AudioSource AudioSource;
    public AudioClip buttomclicksound;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip = buttomclicksound;
    }
    public void Mainbutton()
    {
        Color color = mainbtn.GetComponent<Image>().color;
        color.a = 0.5f;
        mainbtn.GetComponent<Image>().color = color;
        Color colord = Dunbtn.GetComponent<Image>().color;
        colord.a = 1f;
        Color colors = Shopbtn.GetComponent<Image>().color;
        colors.a = 1f;
        Dunbtn.GetComponent<Image>().color = colord;
        Shopbtn.GetComponent<Image>().color = colord;
        maincanvas.SetActive(true);
        Duncanvas.SetActive(false);
        Shopcanvas.SetActive(false);
        TranslucentLayer.SetActive(false);
    }
   public void Dunbutton()
    {
        Color color = mainbtn.GetComponent<Image>().color;
        color.a = 1f;
        mainbtn.GetComponent<Image>().color = color;
        Color colord = Dunbtn.GetComponent<Image>().color;
        colord.a = 0.5f;
        Color colors = Shopbtn.GetComponent<Image>().color;
        colors.a = 1f;
        Dunbtn.GetComponent<Image>().color = colord;
        Shopbtn.GetComponent<Image>().color = colors;
        maincanvas.SetActive(false);
        Shopcanvas.SetActive(false);
        Duncanvas.SetActive(true);
        Modcanvas.SetActive(true);
        TranslucentLayer.SetActive(true);
    }
    public void Shopbutton()
    {
        Color color = mainbtn.GetComponent<Image>().color;
        color.a = 1f;
        mainbtn.GetComponent<Image>().color = color;
        Color colord = Dunbtn.GetComponent<Image>().color;
        colord.a = 1f; 
        Color colors = Shopbtn.GetComponent<Image>().color;
        colors.a = 0.5f;
        Dunbtn.GetComponent<Image>().color = colord;
        Shopbtn.GetComponent<Image>().color = colors;
        maincanvas.SetActive(false);
        Duncanvas.SetActive(false);
        Shopcanvas.SetActive(true);
        TranslucentLayer.SetActive(true);
    }

    public void buttomsound() 
    {
        AudioSource.Play();
    }

}

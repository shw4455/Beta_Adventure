using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_CharSel : MonoBehaviour
{
    public Image btn1, btn2, btn3, btn4;
    public void Charbtn1()
    {
        btn1.GetComponent<Image>().color=Color.red;
        btn2.GetComponent<Image>().color=Color.white;
        btn3.GetComponent<Image>().color=Color.white;
        btn4.GetComponent<Image>().color=Color.white;
      
        DataManager.CharNum = 1;
    }
    public void Charbtn2()
    {
        btn1.GetComponent<Image>().color = Color.white;
        btn2.GetComponent<Image>().color = Color.red;
        btn3.GetComponent<Image>().color = Color.white;
        btn4.GetComponent<Image>().color = Color.white;
        DataManager.CharNum = 2;
    }
    public void Charbtn3()
    {
        btn1.GetComponent<Image>().color = Color.white;
        btn2.GetComponent<Image>().color = Color.white;
        btn3.GetComponent<Image>().color = Color.red;
        btn4.GetComponent<Image>().color = Color.white;
        DataManager.CharNum = 3;
    }
    public void Charbtn4()
    {
        btn1.GetComponent<Image>().color = Color.white;
        btn2.GetComponent<Image>().color = Color.white;
        btn3.GetComponent<Image>().color = Color.white;
        btn4.GetComponent<Image>().color = Color.red;
        DataManager.CharNum = 4;
    }
}

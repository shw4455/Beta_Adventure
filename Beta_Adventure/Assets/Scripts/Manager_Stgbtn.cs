using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_Stgbtn : MonoBehaviour
{
    public void stgbtn1()
    {
        SceneManager.LoadScene("Scene_Battle_1");
        UIManager.SceneIndex = 1;
    }
    public void stgbtn2()
    {
        SceneManager.LoadScene("Scene_Battle_2");
        UIManager.SceneIndex = 2;
    }
    public void stgbtn3()
    {
        SceneManager.LoadScene("Scene_Battle_3");
        UIManager.SceneIndex = 3;
    }
    public void stgbtn4()
    {
        SceneManager.LoadScene("Scene_Battle_4");
        UIManager.SceneIndex = 4;
    }
    public void stgbtn5()
    {
        SceneManager.LoadScene("Scene_Battle_5");
        UIManager.SceneIndex = 5;
    }
}

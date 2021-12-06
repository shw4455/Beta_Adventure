using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_StageSelectButton : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject setting;
    public bool isClick=false;
    public static int stgnum = 0;
    public void SelectLevel(int level)
    {
        if (stgnum != level && stgnum != 0)
        {
            GameObject btn1 = GameObject.Find("Btn" + stgnum);
            btn1.GetComponent<Image>().color = Color.white;
        }
        GameObject btn = GameObject.Find("Btn" + level);
        btn.GetComponent<Image>().color = Color.red;
        stgnum = level;
    }
    public void StartBattlButton()
    {
        SceneManager.LoadScene("Scene_Battle_" + stgnum);
    }
    public void StageActivated()
    {
        if (!isClick)
        {
            Stage1.SetActive(true);
            Stage2.SetActive(true);
            Stage3.SetActive(true);
            isClick = true;

        }
       else if (isClick)
        {
            Stage1.SetActive(false);
            Stage2.SetActive(false);
            Stage3.SetActive(false);
            isClick = false;
        }
    }
    public void ReturnButton()
    {
        SceneManager.LoadScene("Scene_Start");
    }
    public void SettingButton()
    {
        setting.SetActive(true);
    }


}

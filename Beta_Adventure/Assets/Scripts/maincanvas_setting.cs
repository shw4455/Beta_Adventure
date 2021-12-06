using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincanvas_setting : MonoBehaviour
{
    public GameObject setting;
    public void set()
    {
        if (setting.activeSelf == true)
        {
            setting.SetActive(false);
        }
        else if (setting.activeSelf == false)
        {
            setting.SetActive(true);
        }

    }

}

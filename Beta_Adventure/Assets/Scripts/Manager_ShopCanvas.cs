using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_ShopCanvas : MonoBehaviour
{

    public GameObject Upcanvas;
    public GameObject Selcanvas;
    public GameObject tempcanvas;

    public void Upbutton()
    {
        Upcanvas.SetActive(true);
        Selcanvas.SetActive(false);
        tempcanvas.SetActive(false);
    }
    public void Selbutton()
    {
        Upcanvas.SetActive(false) ;
        Selcanvas.SetActive(true);
        tempcanvas.SetActive(false);
    }
    public void tempbutton()
    {
        Upcanvas.SetActive(false);
        Selcanvas.SetActive(false);
        tempcanvas.SetActive(true);
    }
}



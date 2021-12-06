using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dfatk : MonoBehaviour
{
    void Start()
    {
        Invoke("mvoe", 0.01f);
        Invoke("bige", 0.001f);
        
        

    }
    public void bige()
    {
        transform.localScale = new Vector3(0.8f, 0.8f, 0);
    }
    public void mvoe()
    {
        transform.position = transform.position + new Vector3(0.01f, 0, 0);
    }


}

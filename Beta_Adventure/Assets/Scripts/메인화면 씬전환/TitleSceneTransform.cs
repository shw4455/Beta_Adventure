using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneTransform : MonoBehaviour
{
    public GameObject canvas;
    public void SceneTransform() 
    {
        SceneManager.LoadScene("MainScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

    public void SelectStage(int n) // click event
    {
        if (UnlockManager.instance.GetUnlock(n))
            SceneManager.LoadScene("Scene_Battle_" + (n + 1));
    }
}

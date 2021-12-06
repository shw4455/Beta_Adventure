using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockManager : MonoBehaviour
{
    public static UnlockManager instance;

    private bool?[] unlockCondition = new bool?[3];

    private void Awake()
    {
        unlockCondition[0] = true;

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void SetUnlock(int n)
    {
        unlockCondition[n] = true;
    }

    public bool GetUnlock(int n)
    {
        if (unlockCondition[n] != null)
            return (bool)unlockCondition[n];
        else
        {
            Debug.Log("Not allocate unlock memory!");
            return false;
        }
    }
}

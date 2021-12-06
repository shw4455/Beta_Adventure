using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_BCharSel : MonoBehaviour
{
    public Animator animator;
    
    void awake()
    {
        animator.runtimeAnimatorController = Resources.Load("Assets/alex") as RuntimeAnimatorController;
    }


}

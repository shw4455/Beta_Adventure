using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchMove2 : MonoBehaviour
{
    void FixedUpdate()
    {
        LeftMove();
        Invoke("RightMove", 1f);
    }
    void RightMove()
    {
        transform.position = transform.position + new Vector3(0.2f, 0, 0);
    }
    void LeftMove()
    {
        transform.position = transform.position + new Vector3(-0.1f, 0, 0);
    }
}

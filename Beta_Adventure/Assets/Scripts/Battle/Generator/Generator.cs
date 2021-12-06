using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : MonoBehaviour
{
    public int Count;
    public float DestroyTime;
    public static float Spawntime;
    public bool onAttack;
    public Transform[] position_X;
    public Transform[] position_Y;

    protected void Attack()
    {
        
        if (onAttack)
        {
            onAttack = false;
            for (int i = 0; i < Count; i++)
                StartCoroutine(SpawnItem());
        }
        else
            StopCoroutine(SpawnItem());
    }

    protected abstract IEnumerator SpawnItem();

    protected virtual float SetLineX_X()
    {
        float Fx_X = 0.0f;
        int Irandomy = Random.Range(1, 7);

        switch (Irandomy)
        {
            case 1: Fx_X = position_X[0].position.x; break;
            case 2: Fx_X = position_X[1].position.x; break;
            case 3: Fx_X = position_X[2].position.x; break;
            case 4: Fx_X = position_X[3].position.x; break;
            case 5: Fx_X = position_X[4].position.x; break;
            case 6: Fx_X = position_X[5].position.x; break;
        }

        return Fx_X;
    }

    protected virtual float SetLineX_Y()
    {
        float Fx_Y = 0.0f;
        int Irandomy = Random.Range(1, 7);

        switch (Irandomy)
        {
            case 1: Fx_Y = position_X[0].position.y; break;
            case 2: Fx_Y = position_X[1].position.y; break;
            case 3: Fx_Y = position_X[2].position.y; break;
            case 4: Fx_Y = position_X[3].position.y; break;
            case 5: Fx_Y = position_X[4].position.y; break;
            case 6: Fx_Y = position_X[5].position.y; break;
        }

        return Fx_Y;
    }

    protected virtual float SetLineY_X()
    {
        float Fy_X = 0.0f;
        int Irandomy = Random.Range(1, 7);

        switch (Irandomy)
        {
            case 1: Fy_X = position_Y[0].position.x; break;
            case 2: Fy_X = position_Y[1].position.x; break;
            case 3: Fy_X = position_Y[2].position.x; break;
            case 4: Fy_X = position_Y[3].position.x; break;
            case 5: Fy_X = position_Y[4].position.x; break;
            case 6: Fy_X = position_Y[5].position.x; break;
        }
        return Fy_X;
    }

    protected virtual float SetLineY_Y()
    {
        float Fy_Y = 0.0f;
        int Irandomy = Random.Range(1, 7);

        switch (Irandomy)
        {
            case 1: Fy_Y = position_Y[0].position.y; break;
            case 2: Fy_Y = position_Y[1].position.y; break;
            case 3: Fy_Y = position_Y[2].position.y; break;
            case 4: Fy_Y = position_Y[3].position.y; break;
            case 5: Fy_Y = position_Y[4].position.y; break;
            case 6: Fy_Y = position_Y[5].position.y; break;
        }
        return Fy_Y;
    }
    protected virtual float SetLineS_Y()
    {
        float Fs_Y = 0.0f;
        int Irandomy = Random.Range(1, 7);

        switch (Irandomy)
        {
            case 1: Fs_Y = position_Y[0].position.y; break;
            case 2: Fs_Y = position_Y[1].position.y; break;
            case 3: Fs_Y = position_Y[2].position.y; break;
            case 4: Fs_Y = position_Y[3].position.y; break;
            case 5: Fs_Y = position_Y[4].position.y; break;
            case 6: Fs_Y = position_Y[5].position.y; break;
        }
        return Fs_Y;
    }
}

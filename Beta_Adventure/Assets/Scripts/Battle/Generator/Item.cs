using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Generator
{
    public GameObject item;

    private void Awake()
    {
        StartCoroutine(SpawnItem());
    }

    protected override IEnumerator SpawnItem()
    {
        float temp_X = 0.0f, temp_Y = 0.0f;

        temp_X = SetLineX_X();
        temp_Y = SetLineY_Y();

        yield return new WaitForSeconds(Spawntime);
        SpawnItem(temp_X, temp_Y);
    }

    protected void SpawnItem(float Fx, float Fy)
    {
        Instantiate(item, new Vector3(Fx, Fy, 0f), Quaternion.identity);
    }
}

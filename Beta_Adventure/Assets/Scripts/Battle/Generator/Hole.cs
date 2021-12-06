using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : Generator
{
    public GameObject hole;
    public GameObject warningHole;

    private void Awake()
    {
        onAttack = true;  
    }

    private void Update()
    {
        Attack();
    }

    protected override IEnumerator SpawnItem()
    {
        float temp_X = 0.0f, temp_Y = 0.0f;

        temp_X = SetLineX_X();
        temp_Y = SetLineY_Y();

        yield return StartCoroutine(SpawnHole(temp_X, temp_Y));
        yield return new WaitForSeconds(Spawntime);
        StartCoroutine(SpawnItem());
    }

    IEnumerator SpawnHole(float Fx, float Fy)
    {
        GameObject warning = (GameObject)Instantiate(warningHole, new Vector3(Fx, Fy, 0f), Quaternion.identity);
        Destroy(warning, DestroyTime);
        yield return new WaitForSeconds(DestroyTime);

        GameObject attack = (GameObject)Instantiate(hole, new Vector3(Fx, Fy, 0f), Quaternion.identity);
        Destroy(attack, DestroyTime);
        yield return new WaitForSeconds(DestroyTime);
    }
}

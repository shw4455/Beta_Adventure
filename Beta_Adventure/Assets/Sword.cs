using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Generator
{
    public GameObject arrow_Y;
    public GameObject arrow_X;
    public GameObject warningArrow_Y;
    public GameObject warningArrow_X;

    private enum Direction { x, y };
    private Direction direction;

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

        int ranValue = (int)Random.Range(0, 2);
        if (ranValue == 0)
        {
            temp_X = SetLineX_X();
            temp_Y = SetLineS_Y();

            yield return StartCoroutine(SpawnArrow(temp_X, temp_Y, Direction.x));
        }

        yield return new WaitForSeconds(Spawntime);
        StartCoroutine(SpawnItem());
    }

    IEnumerator SpawnArrow(float Fx, float Fy, Direction dir)
    {
        switch (dir)
        {
            case Direction.x:
                GameObject warning_X = (GameObject)Instantiate(warningArrow_X, new Vector3(Fx, Fy, 0f), Quaternion.Euler(0, 0, 90));
                Destroy(warning_X, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);

                GameObject attack_X = (GameObject)Instantiate(arrow_X, new Vector3(Fx , Fy+0.1f, 0f), Quaternion.identity);
                GameObject attack_Y = (GameObject)Instantiate(arrow_Y, new Vector3(Fx , Fy+0.1f, 0f), Quaternion.identity);
                Destroy(attack_X, DestroyTime);
                Destroy(attack_Y, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);
                break;
        }
    }
}

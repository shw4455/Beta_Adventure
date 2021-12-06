using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branch : Generator
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
            temp_Y = SetLineX_Y();

            yield return StartCoroutine(SpawnArrow(temp_X, temp_Y, Direction.x));
        }
        else if (ranValue == 1)
        {
            temp_X = SetLineY_X();
            temp_Y = SetLineY_Y();
            yield return StartCoroutine(SpawnArrow(temp_X, temp_Y, Direction.y));
        }

        yield return new WaitForSeconds(Spawntime);
        StartCoroutine(SpawnItem());
    }

    IEnumerator SpawnArrow(float Fx, float Fy, Direction dir)
    {
        switch (dir)
        {
            case Direction.x:
                GameObject warning_X = (GameObject)Instantiate(warningArrow_X, new Vector3(Fx, Fy, 0f), Quaternion.Euler(0, 0, 0));
                Destroy(warning_X, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);

                GameObject attack_X = (GameObject)Instantiate(arrow_X, new Vector3(Fx+5f, Fy, 0f), Quaternion.identity);
                Destroy(attack_X, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);
                break;
            case Direction.y:
                GameObject warning_Y = (GameObject)Instantiate(warningArrow_Y, new Vector3(Fx, Fy, 0f), Quaternion.identity);
                Destroy(warning_Y, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);

                GameObject attack_Y = (GameObject)Instantiate(arrow_Y, new Vector3(Fx-5f, Fy, 0f), Quaternion.identity);
                Destroy(attack_Y, DestroyTime);
                yield return new WaitForSeconds(DestroyTime);
                break;
        }
    }
}

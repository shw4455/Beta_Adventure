using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public enum Direction { x, y };
    public Direction direction;
    public float shotSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (direction == Direction.x)
        {
            transform.Translate(new Vector2(shotSpeed, 0) * Time.deltaTime);
        }

        if (direction == Direction.y)
        {
            transform.Translate(new Vector2(0, -shotSpeed) * Time.deltaTime);
        }
    }
}

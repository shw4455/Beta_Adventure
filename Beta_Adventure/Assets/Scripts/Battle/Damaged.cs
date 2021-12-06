using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{
    public float feverDownValue;
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Player>().Damaged(damage);
            collision.gameObject.GetComponent<Player>().UImanager.DownFever(feverDownValue);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float hp;
    public float damage;
    public float feverUpValue;
    public GameObject attackeffect;
    public Transform[] positionX;
    public Transform[] positionY;
    public AudioClip moveClip;
    public AudioClip attackClip;
    public AudioClip damagedClip;
    public AudioClip attackmonster;
    public Image[] heartImage;
    public UIManager UImanager;
    public Enemy enemy;

    private float moveDirection_x = 0;
    private float moveDirection_y = 0;
    private bool onMove = false;
    
    private Animator anim;
    private AudioSource audioSource;

    private Vector2 preTouch;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (DataManager.CharNum == 1)
        {
            if (anim.gameObject.activeSelf)
            {
                anim.runtimeAnimatorController = Resources.Load("Animation/alex") as RuntimeAnimatorController;
            }
        }
        else if (DataManager.CharNum == 2)
        {
            if (anim.gameObject.activeSelf)
            {
                anim.runtimeAnimatorController = Resources.Load("Animation/beta") as RuntimeAnimatorController;
            }
        }
        else if (DataManager.CharNum == 3)
        {
            if (anim.gameObject.activeSelf)
            {
                anim.runtimeAnimatorController = Resources.Load("Animation/katus") as RuntimeAnimatorController;
            }
        }
        else if (DataManager.CharNum == 4)
        {
            if (anim.gameObject.activeSelf)
            {
                anim.runtimeAnimatorController = Resources.Load("Animation/silrin") as RuntimeAnimatorController;
            }
        }

        //DetectTouch();

        //#.Move
        MovePlayer();

        //#.Update Heart
        UpdateHeart();

        //#.GameOver, if hp <= 0
        GameOver();
    }

    public void Damaged(float damage)
    {
        if (hp > 0)
        {
            hp -= damage;
            PlaySoundEffect(damagedClip);
        }
    }

    /*
    private void DetectTouch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            preTouch = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            const float MINIMUM_VALUE = 100.0f;
            onMove = true;
            Vector2 nowTouch = Input.mousePosition;

            float interval_x = Mathf.Abs(nowTouch.x - preTouch.x);
            float interval_y = Mathf.Abs(nowTouch.y - preTouch.y);

            if (interval_x >= interval_y && interval_x > MINIMUM_VALUE)
            {
                if (nowTouch.x < preTouch.x) // left
                {
                    if (transform.position.x <= positionX[0].position.x + 0.25f)
                    {
                        moveDirection_x = 0;
                        moveDirection_y = 0;
                        return;
                    }

                    moveDirection_x = -1;
                }
                else if (nowTouch.x > preTouch.x) // right
                {
                    if (transform.position.x >= positionX[5].position.x - 0.25f)
                    {
                        moveDirection_x = 0;
                        moveDirection_y = 0;
                        return;
                    }

                    moveDirection_x = 1;
                }

                moveDirection_y = 0;
            }
            else if (interval_x < interval_y && interval_y > MINIMUM_VALUE)
            {
                if (nowTouch.y < preTouch.y) // down
                {
                    if (transform.position.y <= positionY[5].position.y + 0.25f)
                    {
                        moveDirection_x = 0;
                        moveDirection_y = 0;
                        return;
                    }

                    moveDirection_y = -1;
                }
                else if (nowTouch.y > preTouch.y) // up
                {
                    if (transform.position.y >= positionY[0].position.y - 0.25f)
                    {
                        moveDirection_x = 0;
                        moveDirection_y = 0;
                        return;
                    }

                    moveDirection_y = 1;
                }

                moveDirection_x = 0;
            }
            else // Don't Move!
            {
                moveDirection_x = 0;
                moveDirection_y = 0;
            }
        }
    }
    */

    public void UpMove()
    {
        if (transform.position.y >= positionY[0].position.y - 0.25f)
            return;

        moveDirection_x = 0.0f;
        moveDirection_y = 1.0f;
        onMove = true;
    }

    public void DownMove()
    {
        if (transform.position.y <= positionY[5].position.y + 0.25f)
            return;

        moveDirection_x = 0.0f;
        moveDirection_y = -1.0f;
        onMove = true;
    }

    public void LeftMove()
    {
        if (transform.position.x <= positionX[0].position.x + 0.25f)
            return;

        moveDirection_x = -1.0f;
        moveDirection_y = 0.0f;
        onMove = true;
    }

    public void RightMove()
    {
        if (transform.position.x >= positionX[5].position.x - 0.25f)
            return;

        moveDirection_x = 1.0f;
        moveDirection_y = 0.0f;
        onMove = true;
    }

    private void MovePlayer()
    {
        if (!onMove)
            return;

        const float SET_VALUE = 0.715f;
        transform.Translate(SET_VALUE * moveDirection_x, SET_VALUE * moveDirection_y, 0);

        if (moveDirection_x == 0)
        {
            if (moveDirection_y > 0)
            {
                anim.SetTrigger("up");
            }
            else if (moveDirection_y < 0)
            {
                ; // down
            }
        }
        else
        {
            if (moveDirection_x < 0)
            {
                anim.SetTrigger("left");
            }
            else if (moveDirection_x > 0)
            {
                anim.SetTrigger("right");
            }
        }

        PlaySoundEffect(moveClip);

        onMove = false;
        moveDirection_x = 0.0f;
        moveDirection_y = 0.0f;
    }

    /*
    private void MovePlayer()
    {
        if (!onMove || (moveDirection_x == 1 && moveDirection_y == 1))
            return;

        const float SET_VALUE = 0.715f;

        transform.Translate(SET_VALUE * moveDirection_x, SET_VALUE * moveDirection_y, 0);

        if (moveDirection_x == 0)
        {
            if (moveDirection_y > 0)
            {
                anim.SetTrigger("up");
            }
            else if (moveDirection_y < 0)
            {
                ; // down
            }
        }
        else
        {
            if (moveDirection_x < 0)
            {
                anim.SetTrigger("left");
            }
            else if (moveDirection_x > 0)
            {
                anim.SetTrigger("right");
            }
        }

        PlaySoundEffect(moveClip);
        onMove = false;
    }
    */

    private void UpdateHeart()
    {
        switch (hp)
        {
            case 6:
                heartImage[0].fillAmount = 1.0f;
                heartImage[1].fillAmount = 1.0f;
                heartImage[2].fillAmount = 1.0f;
                return;
            case 5:
                heartImage[0].fillAmount = 1.0f;
                heartImage[1].fillAmount = 1.0f;
                heartImage[2].fillAmount = 0.5f;
                return;
            case 4:
                heartImage[0].fillAmount = 1.0f;
                heartImage[1].fillAmount = 1.0f;
                heartImage[2].fillAmount = 0.0f;
                return;
            case 3:
                heartImage[0].fillAmount = 1.0f;
                heartImage[1].fillAmount = 0.5f;
                heartImage[2].fillAmount = 0.0f; 
                return;
            case 2:
                heartImage[0].fillAmount = 1.0f;
                heartImage[1].fillAmount = 0.0f;
                heartImage[2].fillAmount = 0.0f;
                return;
            case 1:
                heartImage[0].fillAmount = 0.5f;
                heartImage[1].fillAmount = 0.0f;
                heartImage[2].fillAmount = 0.0f;
                return;
            case 0:
                heartImage[0].fillAmount = 0.0f;
                heartImage[1].fillAmount = 0.0f;
                heartImage[2].fillAmount = 0.0f;
                return;
        }
    }

    private void GameOver()
    {
        if (hp > 0)
            return;

        UImanager.ShowResult(hp);
    }

    private void Attack()
    {
        enemy.hp -= damage;
        UImanager.UpFever(feverUpValue);
        GameObject atk = (GameObject)Instantiate(attackeffect, new Vector3(1f, 3f, 10f), Quaternion.identity);
        Destroy(atk, 1.2f);
    }

    private void PlaySoundEffect(AudioClip tempCiip)
    {
        audioSource.clip = tempCiip;
        audioSource.Play();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            Attack();
            PlaySoundEffect(attackClip);
            PlaySoundEffect(attackmonster);
            GameObject.Find("Item Generator").GetComponent<Item>().StartCoroutine("SpawnItem");
            Destroy(collision.gameObject);
        }
    }
}

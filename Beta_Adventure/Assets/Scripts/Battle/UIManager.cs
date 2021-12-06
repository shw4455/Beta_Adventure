using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject result;
    public GameObject pause;
    public AudioClip completeClip;
    public AudioClip failClip;
    public Image[] resultHeart;
    public Image completeText;
    public Image failText;
    public Slider FeverGauge;
    public static int SceneIndex;

    private bool onPlay = false;
    private bool onDownFever = false;
    private float feverValue = 0.0f;

    private AudioSource audioSource;

    private void Awake()
    {
        Time.timeScale = 1.0f;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        SetGauge();
        FixFever();
        DownFever();
    }

    public void ShowResult(float hp)
    {
        Time.timeScale = 0.0f;

        result.SetActive(true);

        if (hp <= 0)
        {
            PlaySoundEffect(failClip);
            onPlay = true;
            completeText.enabled = false;
            failText.enabled = true;
        }
        else
        {
            PlaySoundEffect(completeClip);
            onPlay = true;
            completeText.enabled = true;
            failText.enabled = false;
        }

        UpdateHeart(hp);
    }

    public void ReGame()
    {
        SceneManager.LoadScene("Scene_Battle_" + SceneIndex);
    }

    public void BackHome()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainScene");
    }

    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Continue()
    {
        pause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void UpFever(float value)
    {
        feverValue += value;
        if (feverValue >= 100)
            feverValue = 100;
    }

    public void DownFever(float value)
    {
        feverValue -= value;
        if (feverValue <= 0)
            feverValue = 0;
    }

    public void DownFever()
    {
        if (onDownFever)
            return;

        const float FEVER_DOWN_VALUE = 1.75f;
        feverValue -= Time.deltaTime * FEVER_DOWN_VALUE;
        if (feverValue <= 0)
            feverValue = 0;
    }

    public void FixFever()
    {
        if (feverValue == FeverGauge.maxValue)
            onDownFever = true;
        else
            onDownFever = false;
    }

    public void FeverZero()
    {
        feverValue = 0;
    }

    private void UpdateHeart(float hp)
    {
        switch (hp)
        {
            case 6:
                resultHeart[0].fillAmount = 1.0f;
                resultHeart[1].fillAmount = 1.0f;
                resultHeart[2].fillAmount = 1.0f;
                return;
            case 5:
                resultHeart[0].fillAmount = 1.0f;
                resultHeart[1].fillAmount = 1.0f;
                resultHeart[2].fillAmount = 0.5f;
                return;
            case 4:
                resultHeart[0].fillAmount = 1.0f;
                resultHeart[1].fillAmount = 0.5f;
                resultHeart[2].fillAmount = 0.0f;
                return;
            case 3:
                resultHeart[0].fillAmount = 1.0f;
                resultHeart[1].fillAmount = 0.0f;
                resultHeart[2].fillAmount = 0.0f;
                return;
            case 2:
                resultHeart[0].fillAmount = 1.0f;
                resultHeart[1].fillAmount = 0.0f;
                resultHeart[2].fillAmount = 0.0f;
                return;
            case 1:
                resultHeart[0].fillAmount = 0.5f;
                resultHeart[1].fillAmount = 0.0f;
                resultHeart[2].fillAmount = 0.0f;
                return;
            case 0:
                resultHeart[0].fillAmount = 0.0f;
                resultHeart[1].fillAmount = 0.0f;
                resultHeart[2].fillAmount = 0.0f;
                return;
        }
    }

    private void SetGauge()
    {
        FeverGauge.value = feverValue;
    }

    private void PlaySoundEffect(AudioClip tempCiip)
    {
        if (onPlay)
            return;

        audioSource.clip = tempCiip;
        audioSource.Play();
    }
}

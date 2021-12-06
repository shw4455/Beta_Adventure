using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float hp;
    public int unlockValue;

    public Player player;
    public Slider hpBar;

    private void Awake()
    {
        hpBar.maxValue = hp;
    }

    private void Update()
    {
        UpdateGauge();
        SilRage();
        Victory();
    }

    private void UpdateGauge()
    {
        hpBar.value = hp;
    }
    private void SilRage()
    {
        if (hp < hpBar.maxValue / 2)
        {
            Generator.Spawntime = 0.1f;
        }
    }
    private void Victory()
    {
        if (hp > 0)
            return;

        player.UImanager.ShowResult(player.hp);
 
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    private GameManager gm;
    private int init_Speed;
    private int init_Multiplier;
    private int init_SlowDeplete;

    [SerializeField] private Image[] UpgradeArray1;
    [SerializeField] private Image[] UpgradeArray2;
    [SerializeField] private Image[] UpgradeArray3;

    private void Awake()
    {
        gm = GameManager.instance;
    }

    private void OnEnable()
    {
        //init_Speed = gm.GetUpgradeDictionary()[ECollectible.SpeedCollectible];
        //init_Multiplier = gm.GetUpgradeDictionary()[ECollectible.MultiplierCollectible];
        //init_SlowDeplete = gm.GetUpgradeDictionary()[ECollectible.SlowDepleteCollectible];

        init_Speed = 5;
        init_Multiplier = 5;
        init_SlowDeplete = 5;


        UpdateUpgradeData();
    }

    private void UpdateUpgradeData()
    {
        for (var i = 0; i < init_Speed; i++)
        {
            UpgradeArray1[i].color = new Color(1, 197, 0, 255);
        }
        for (var i = 0; i < init_Multiplier; i++)
        {
            UpgradeArray2[i].color = new Color(100, 119, 198, 255);
        }
        for (var i = 0; i < init_SlowDeplete; i++)
        {
            UpgradeArray3[i].color = new Color(198, 4, 0, 255);
        }
    }

    private void SetUpgradeValue()
    {
        gm.GetUpgradeDictionary()[ECollectible.SpeedCollectible] += 1;
    }
}

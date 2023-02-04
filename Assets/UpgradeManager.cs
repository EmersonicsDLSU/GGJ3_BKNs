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
        init_Speed = gm.GetUpgradeDictionary()[ECollectible.SpeedCollectible];
        init_Multiplier = gm.GetUpgradeDictionary()[ECollectible.MultiplierCollectible];
        init_SlowDeplete = gm.GetUpgradeDictionary()[ECollectible.SlowDepleteCollectible];

        Debug.Log(init_Speed);
        Debug.Log(init_Multiplier);
        Debug.Log(init_SlowDeplete);

        UpdateUpgradeData();
    }

    private void UpdateUpgradeData()
    {
        for (var i = 0; i < init_Speed; i++)
        {
            UpgradeArray1[i].color = new Color32(1, 197, 0, 255);
        }
        for (var i = 0; i < init_Multiplier; i++)
        {
            UpgradeArray2[i].color = new Color32(100, 119, 198, 255);
        }
        for (var i = 0; i < init_SlowDeplete; i++)
        {
            UpgradeArray3[i].color = new Color32(198, 4, 0, 255);
        }
    }

    public void SetUpgradeValue(int index)
    {
        switch (index)
        {
            case 0:
                
                gm.GetUpgradeDictionary()[ECollectible.SpeedCollectible] += 1;
                break;
            case 1:
                gm.GetUpgradeDictionary()[ECollectible.MultiplierCollectible] += 1;
                break;
            case 2:
                gm.GetUpgradeDictionary()[ECollectible.SlowDepleteCollectible] += 1;
                break;
            default:
                break;
        }
                UpdateGameManagerData();

    }

    private void UpdateGameManagerData()
    {
        init_Speed = gm.GetUpgradeDictionary()[ECollectible.SpeedCollectible];
        init_Multiplier = gm.GetUpgradeDictionary()[ECollectible.MultiplierCollectible];
        init_SlowDeplete = gm.GetUpgradeDictionary()[ECollectible.SlowDepleteCollectible];

        UpdateUpgradeData();
    }
}

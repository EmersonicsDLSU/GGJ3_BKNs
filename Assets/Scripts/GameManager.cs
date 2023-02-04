using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : tSingleton<GameManager>
{
    private int playerScore = 0;
    private Dictionary<ECollectible, int> collectibleUpgradeLevel = new Dictionary<ECollectible, int>();
    private float gameTime = 0.0f;


    protected override void Awake()
    {
        base.Awake();

        //for now, upgrade values are reset every new playthrough
        //values are defaulted at 1

        collectibleUpgradeLevel[ECollectible.SpeedCollectible] = 1;
        collectibleUpgradeLevel[ECollectible.MultiplierCollectible] = 1;
        collectibleUpgradeLevel[ECollectible.SlowDepleteCollectible] = 1;

    }

    public int GetPlayerScore()
    { 
        return playerScore; 
    }

    public Dictionary<ECollectible, int> GetUpgradeDictionary()
    {
        return collectibleUpgradeLevel;
    }

    public float GetGameTime()
    {
        return gameTime;
    }
}

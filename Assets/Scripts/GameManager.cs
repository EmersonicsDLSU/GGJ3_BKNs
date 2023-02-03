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
        
    }
}

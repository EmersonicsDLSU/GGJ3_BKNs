using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public long lastUpdated;
    public float _longestTimeSurvived;
    public int _highScore;

    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        _longestTimeSurvived = 0.0f;
        _highScore = 0;
    }

}
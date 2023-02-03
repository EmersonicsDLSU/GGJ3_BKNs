using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public long lastUpdated;
    public string dateCreated;
    public string timeCreated;
    public Vector3 respawnPoint;
    public int totalDeath;

    public int currentRespawnPoint;

    // List of respawn and cutscene elements in the game
    public SerializableDictionary<int, bool> respawnTriggerPassed;
    public SerializableDictionary<int, bool> cutsceneTriggerPassed;
    public SerializableDictionary<int, bool> objectivesDone;
    public SerializableDictionary<int, bool> journalImagesTaken;

    // the values defined in this constructor will be the default values
    // the game starts with when there's no data to load
    public GameData()
    {
        respawnPoint = new Vector3(-249.49f, 14.79f, -2.98f);
        this.totalDeath = 0;
        respawnTriggerPassed = new SerializableDictionary<int, bool>();
        cutsceneTriggerPassed = new SerializableDictionary<int, bool>();
        objectivesDone = new SerializableDictionary<int, bool>();
        journalImagesTaken = new SerializableDictionary<int, bool>();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MPAttribs
{
    [Tooltip("Player current speed multiplier")]
    public float playerSpeed = 1.0f;
    [Tooltip("Player current health")]
    public float playerHealth = 100.0f;
    [Tooltip("Player current depletion multiplier")]
    public float depletionMultiplier = 0.01f;
}

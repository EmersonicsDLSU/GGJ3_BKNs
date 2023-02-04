using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCollectible : ACollectible
{
    private MainPlayer mainPlayerReference = null;

    // Start is called before the first frame update
    void Start()
    {
        mainPlayerReference = FindObjectOfType<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ApplyEffect()
    {
        mainPlayerReference.MainPlayerAttributes.playerSpeed = GameManager.instance.GetUpgradeDictionary()[ECollectible.SpeedCollectible];
    }


}

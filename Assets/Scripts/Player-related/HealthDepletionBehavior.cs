using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDepletionBehavior : MonoBehaviour, IMPRefs
{
    public void RefStart(MainPlayer mainRef)
    {

    }

    public void RefUpdate(MainPlayer mainRef)
    {
        mainRef.MainPlayerAttributes.playerHealth -= (1 * mainRef.MainPlayerAttributes.depletionMultiplier);
        if (mainRef.MainPlayerAttributes.playerHealth <= 0)
        {
            mainRef.PlayerAnimController.FireDeathAnim();
        }
    }
}

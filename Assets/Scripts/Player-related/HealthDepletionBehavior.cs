using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDepletionBehavior : MonoBehaviour, IMPRefs
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RefUpdate(MainPlayer mainRef)
    {
        mainRef.MainPlayerAttributes.playerHealth -= (1 * mainRef.MainPlayerAttributes.depletionMultiplier);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDepletionBehavior : MonoBehaviour
{
    private MainPlayer mainPlayerSc = null;

    // Start is called before the first frame update
    void Start()
    {
        mainPlayerSc = FindObjectOfType<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Run()
    {

        mainPlayerSc.MainPlayerAttributes.playerHealth -= (1 * mainPlayerSc.MainPlayerAttributes.depletionMultiplier);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDetection : MonoBehaviour
{
    private UI_InfectionCounterScript uiInfectionCounter;
    private MainPlayer mpSc;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        uiInfectionCounter = FindObjectOfType<UI_InfectionCounterScript>();
        mpSc = FindObjectOfType<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        gm = GameManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //check if attack button is clicked
            if(mpSc.PlayerAnimController.CurrentState == ZombieStates.ATTACK)
            {
                // update score
                gm.SetPlayerScore(gm.GetPlayerScore() + 1);
                uiInfectionCounter.UpdateInfectionCountUI(gm.GetPlayerScore());
                //kill NPC by returning to pool
                Debug.LogWarning("KILL");

                //play kill sfx?
            }

        }
    }
}

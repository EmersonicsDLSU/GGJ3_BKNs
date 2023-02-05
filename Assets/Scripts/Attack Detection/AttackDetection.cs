using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDetection : MonoBehaviour
{
    private UI_InfectionCounterScript uiInfectionCounter;
    private MainPlayer mpSc;
    private GameManager gm;

    private HumanAnimController humanAnim;

    private HumanPool humanPool;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;
        uiInfectionCounter = FindObjectOfType<UI_InfectionCounterScript>();
        mpSc = FindObjectOfType<MainPlayer>();
        humanAnim = GetComponent<HumanAnimController>();
        humanPool = GetComponent<HumanPool>();
    }

    // Update is called once per frame
    void Update()
    {
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
                humanAnim._humanAnimation.DeathAnim(humanAnim);
                // Increment money
                CurrencyManager.Instance.AddCurrency(1);
                Invoke("ReturnHumanPool", 5.0f);
                Debug.LogWarning("KILL");

                //play kill sfx?
            }

        }
    }

    void ReturnHumanPool()
    {
        humanPool._objectPool.ReturnObject(humanPool);
    }
}

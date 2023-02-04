using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        {
            //check if attack button is clicked
            if(GetComponent<PlayerAnimController>().CurrentState == ZombieStates.ATTACK)
            {
                //kill NPC by returning to pool
                Debug.LogWarning("KILL");

                //play kill sfx?
            }

        }
    }
}

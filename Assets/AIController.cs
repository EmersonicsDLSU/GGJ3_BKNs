using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private float LocFindCooldown = 4.0f;
    private float nextLoc;
    public NavMeshAgent agent;

    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit anonymous;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out anonymous, radius, 1))
        {
            finalPosition = anonymous.position;
        }
        return finalPosition;
    }

    private void Update()
    {
        if(Time.time > nextLoc)
        {
            nextLoc = Time.time + LocFindCooldown;
            agent.SetDestination(RandomNavmeshLocation(70f));
        }
        
    }
}

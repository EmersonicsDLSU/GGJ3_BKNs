using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tPlayerAnimation : MonoBehaviour, tIHumanAnimation<tPlayerAnimController>
{
    public void IdleAnim(tPlayerAnimController con)
    {
        con.CurrentState = HumanStates.IDLE;
        con._animator.SetFloat("xMove", con._moveInput.x);
        con._animator.SetFloat("yMove", con._moveInput.y);
    }

    public void WalkAnim(tPlayerAnimController con)
    {
        con.CurrentState = HumanStates.WALK;
        con._animator.SetFloat("xMove", con._moveInput.x);
        con._animator.SetFloat("yMove", con._moveInput.y);
    }
}

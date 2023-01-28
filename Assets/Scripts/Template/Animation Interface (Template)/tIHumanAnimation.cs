using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HumanStates
{
    IDLE,
    WALK
}

//public interface tIHumanAnimation<T>
public interface tIHumanAnimation<T>
{
    //public void IH_MoveAnim(ref T param);
    public void IdleAnim(T con);
    public void WalkAnim(T con);
}

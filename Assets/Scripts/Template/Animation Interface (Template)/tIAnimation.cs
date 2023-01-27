using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public interface tIAnimation<T>
public interface tIAnimation
{
    //public void IH_MoveAnim(ref T param);
    public void IH_MoveAnim(bool isRunning);
    public void IH_RunAnim(bool isRunning);
    public void IH_SneakAnim(bool isRunning);
    public void IH_JumpAnim(bool isRunning);
    public void IH_IsGroundAnim(bool isRunning);
    public void IH_IsInteractAnim(bool isRunning);
    public void IH_DeathAnim(bool isRunning);
    public void IH_ConsumeAnim(bool isRunning);
}

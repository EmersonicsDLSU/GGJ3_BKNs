using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public string clipName;

    void Awake()
    {
        tAudioManager.instance.playBGMByName(clipName);
    }
}

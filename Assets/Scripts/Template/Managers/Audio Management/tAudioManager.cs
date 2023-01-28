using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tAudioManager : tSingleton
{
    public List<AudioInfo> Ambience;
    public List<AudioInfo> SFX;
    public List<AudioInfo> VoiceOver;
    public List<AudioInfo> BGM;
    public List<AudioInfo> UI;

    public void Awake()
    {
        tAudioInfo TAudioInfo;

        if (this.gameObject.GetComponentInChildren<tAudioInfo>())
        {
            TAudioInfo = this.gameObject.GetComponentInChildren<tAudioInfo>();
            SortAudio(TAudioInfo.tAudioInfoList);
        }
        else
        {
            Debug.LogWarning("Audio List not found!");
        }
    }

    void SortAudio(List<AudioInfo> list)
    {
        foreach (AudioInfo audio in list)
        {
            if (audio.type == AudioInfoType.Ambience)
                Ambience.Add(audio);
            else if (audio.type == AudioInfoType.SFX)
                SFX.Add(audio);
            else if (audio.type == AudioInfoType.VoiceOver)
                VoiceOver.Add(audio);
            else if (audio.type == AudioInfoType.BGM)
                BGM.Add(audio);
            else if (audio.type == AudioInfoType.UI)
                UI.Add(audio);
        }
    }

    #region Ambience

    public void playAmbienceByName(string name)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.name == name)
            {
                //throw sound
                return;
            }
        }
    }

    public void playAmbienceByTag(string tag)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.tag == tag)
            {
                //throw sound
                return;
            }
        }
    }

    #endregion

    #region SFX

    public void playSFXByName(string name)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.name == name)
            {
                //throw sound
                return;
            }
        }
    }

    public void playSFXByTag(string tag)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.tag == tag)
            {
                //throw sound
                return;
            }
        }
    }

    #endregion

    #region VoiceOver

    public void playVOByName(string name)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.name == name)
            {
                //throw sound
                return;
            }
        }
    }

    public void playVOByTag(string tag)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.tag == tag)
            {
                //throw sound
                return;
            }
        }
    }

    #endregion

    #region BGM

    public void playBGMByName(string name)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.name == name)
            {
                //throw sound
                return;
            }
        }
    }

    public void playBGMByTag(string tag)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.tag == tag)
            {
                //throw sound
                return;
            }
        }
    }

#endregion

    #region UI

    public void playUIByName(string name)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.name == name)
            {
                //throw sound
                return;
            }
        }
    }

    public void playUIByTag(string tag)
    {
        foreach (AudioInfo BGM in BGM)
        {
            if (BGM.tag == tag)
            {
                //throw sound
                return;
            }
        }
    }

    #endregion
}

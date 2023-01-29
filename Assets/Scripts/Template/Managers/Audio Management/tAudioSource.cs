using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tAudioSource : MonoBehaviour
{
    //ComponentReference
    [HideInInspector] public AudioSource _audioSource;
    [HideInInspector] public string _tag;
    [HideInInspector] public AudioInfoType _type;
    private tObjectPool<tAudioSource> audioSourcePool;

    private void Awake()
    {
        _audioSource = this.gameObject.AddComponent<AudioSource>();
    }

    public void AssignObjectPool(tObjectPool<tAudioSource> objectPool)
    {
        audioSourcePool = objectPool;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

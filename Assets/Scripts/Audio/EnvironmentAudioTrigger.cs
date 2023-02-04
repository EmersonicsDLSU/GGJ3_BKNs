using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnvironmentAudioTrigger : MonoBehaviour
{
    [HideInInspector]public SphereCollider _sphereCollider;

    public string clipName;
    public float radius = 5;

    void Awake()
    {
        _sphereCollider = this.AddComponent<SphereCollider>();
        _sphereCollider.isTrigger = true;
        _sphereCollider.radius = radius;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            tAudioManager.instance.playSFXByName(clipName, this.transform);
        }

        Destroy(_sphereCollider);
    }
}

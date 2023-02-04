using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnvironmentAudioTrigger : MonoBehaviour
{
    [HideInInspector]public SphereCollider _sphereCollider;

    public float radius = 5;

    void Awake()
    {
        _sphereCollider = this.AddComponent<SphereCollider>();
        _sphereCollider.isTrigger = true;
        _sphereCollider.radius = radius;
    }
}

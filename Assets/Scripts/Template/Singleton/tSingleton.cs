using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tSingleton : MonoBehaviour
{
    public static tSingleton instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
}

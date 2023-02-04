using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    private List<IMPRefs> _componentList;

    // object's components
    [HideInInspector] public Transform CameraTransform;
    [HideInInspector] public MPAttribs MainPlayerAttributes;
    [HideInInspector] public MPLook MainPlayerLook;

    private void Awake()
    {
        // gets the reference of the components
        CameraTransform = GetComponentInChildren<Camera>().transform;
        if (GetComponentInChildren<MPLook>() != null) MainPlayerLook = GetComponentInChildren<MPLook>();
        else Debug.LogError("Missing 'MPLook' script!");

        // add it to the component list
        _componentList = new List<IMPRefs>();
        _componentList.Add(MainPlayerLook);
    }

    private void Update()
    {
        // controls the update of all components
        foreach (var comp in _componentList)
        {
            comp.RefUpdate(this);
        }
    }
}
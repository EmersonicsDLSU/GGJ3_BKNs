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
    [HideInInspector] public PlayerAnimController PlayerAnimController;

    private void Awake()
    {
        // gets the reference of the components
        CameraTransform = GetComponentInChildren<Camera>().transform;
        if (GetComponentInChildren<MPLook>() != null) MainPlayerLook = GetComponentInChildren<MPLook>();
        else Debug.LogError("Missing 'MPLook' script!");
        if (GetComponentInChildren<PlayerAnimController>() != null) PlayerAnimController = GetComponentInChildren<PlayerAnimController>();
        else Debug.LogError("Missing 'PlayerAnimController' script!");

        // add it to the component list
        _componentList = new List<IMPRefs>();
        _componentList.Add(MainPlayerLook);
        _componentList.Add(PlayerAnimController);
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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tDelegate
{
    private static tDelegate shared_instance = null;

    public static tDelegate GetInstance()
    {
        if (shared_instance == null)
            shared_instance = new tDelegate();

        return shared_instance;
    }

    public Action D_OnDoorOen = null;

    /* How to add to this delegate:
    private void Start()
    {
        tDelegate.GetInstance().D_OnDoorOen += MoveDoor; // MoveDoor can be a private/public func

    }

    public void OnDestroy()
    {
        tDelegate.GetInstance().D_OnDoorOen -= MoveDoor;
    }
     */
}

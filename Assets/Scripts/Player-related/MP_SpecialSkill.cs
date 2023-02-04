using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP_SpecialSkill : MonoBehaviour, IMPRefs
{
    private MainPlayer _mainRef;
    // Start is called before the first frame update
    void Start()
    {
        _mainRef = FindObjectOfType<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefUpdate(MainPlayer mainRef)
    {

    }

    public void FireSpecialSkill()
    {
        _mainRef.PlayerAnimController._animator.SetFloat("SpeedMultiplier", 2.0f);
    }
}

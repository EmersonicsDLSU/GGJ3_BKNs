using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public PlayerInput PlayerInput;

    public MPAttribs MainPlayerAttributes;

    private void OnEnable()
    {
        PlayerInput.Enable ();
    }

    private void OnDisable()
    {
        PlayerInput.Disable ();
    }

    private void Awake()
    {
        PlayerInput = new PlayerInput ();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //For debugging player health depletion
        //Debug.Log(MainPlayerAttributes.playerHealth -= (1 * MainPlayerAttributes.depletionMultiplier));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public MPAttribs MainPlayerAttributes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //For debugging player health depletion
        Debug.Log(MainPlayerAttributes.playerHealth -= (1 * MainPlayerAttributes.depletionMultiplier));
    }
}

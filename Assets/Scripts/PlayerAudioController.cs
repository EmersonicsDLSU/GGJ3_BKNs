using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    private IDictionary<string, string> playerSFX = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        playerSFX.Add("Slash1", "ClawSlash1");
        playerSFX.Add("Slash2", "ClawSlash2");
    }

    public void PlayAttack()
    {
        float rndm = Random.Range(0, 10);

        if (rndm >= 5)
            tAudioManager.instance.playSFXByName(playerSFX["Slash1"], this.transform);
        else if (rndm < 5)
            tAudioManager.instance.playSFXByName(playerSFX["Slash2"], this.transform);
    }

}

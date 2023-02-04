using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StatusEffectHolderScript : MonoBehaviour
{
    [SerializeField] private Transform[] statusEffectGameObjects;

    // Update is called once per frame
    void Update()
    {
        foreach (var statusEffect in statusEffectGameObjects)
        {
            if (statusEffect.transform.Find("RadialBar").GetComponent<Image>().fillAmount <= 0)
                statusEffect.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ActivateStatusEffectUI(1);
        }
    }

    public void ActivateStatusEffectUI(int statusEffectIndex)
    {
        statusEffectGameObjects[statusEffectIndex].gameObject.SetActive(true);
    }
}

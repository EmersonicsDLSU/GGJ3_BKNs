using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPool : MonoBehaviour
{
    protected string sTagToCompare = "Player";

    private ObjectPool<SpeedPool> _objectPool;

    private MainPlayer mainPlayerReference = null;
    private GameManager GameManagerReference = null;

    private UI_StatusEffectHolderScript uiStatusEffect;

    void Start()
    {
        uiStatusEffect = FindObjectOfType<UI_StatusEffectHolderScript>();
    }

    public void AssignObjectPool(ObjectPool<SpeedPool> objectPool)
    {
        _objectPool = objectPool;

        mainPlayerReference = FindObjectOfType<MainPlayer>();
    }

    public GameObject _bloodSplashPrefab;

    void OnCollisionEnter(Collision collision)
    {
        GameManagerReference = GameManager.instance;

        if (collision.transform.CompareTag(sTagToCompare))
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = collision.transform.rotation;
            Vector3 position = contact.point;
            //instantiate a blood splash particle fx
            //Instantiate(_bloodSplashPrefab, position, rotation);

            //call speed buff fxn
            mainPlayerReference.MainPlayerAttributes.playerSpeed =
                GameManagerReference.GetSpeedUpgradeEquivalent(GameManagerReference.GetUpgradeDictionary()[ECollectible.SpeedCollectible]);

            // display effect icon in HUD
            uiStatusEffect.ActivateStatusEffectUI((int)ECollectible.SpeedCollectible);

            Invoke("ResetAttribute", 5.0f);

            _objectPool.ReturnObject(this);
        }
    }

    private void ResetAttribute()
    {
        mainPlayerReference.MainPlayerAttributes.playerSpeed = 1.0f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPool : MonoBehaviour
{
    protected string sTagToCompare = "Player";

    private ObjectPool<SlowPool> _objectPool;

    private MainPlayer mainPlayerReference = null;
    private GameManager GameManagerReference = null;

    public void AssignObjectPool(ObjectPool<SlowPool> objectPool)
    {
        _objectPool = objectPool;

        mainPlayerReference = FindObjectOfType<MainPlayer>();
    }

    public GameObject _bloodSplashPrefab;

    void OnCollisionEnter(Collision collision)
    {
        mainPlayerReference = FindObjectOfType<MainPlayer>();
        GameManagerReference = GameManager.instance;

        if (collision.transform.CompareTag(sTagToCompare))
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = collision.transform.rotation;
            Vector3 position = contact.point;
            //Instantiate(_bloodSplashPrefab, position, rotation);

            //call speed buff fxn
            mainPlayerReference.MainPlayerAttributes.depletionMultiplier =
                GameManagerReference.GetSlowDepleteUpgradeEquivalent(GameManagerReference.GetUpgradeDictionary()[ECollectible.SlowDepleteCollectible]);

            Invoke("ResetAttribute", 5.0f);

            _objectPool.ReturnObject(this);
        }
    }

    private void ResetAttribute()
    {
        mainPlayerReference.MainPlayerAttributes.depletionMultiplier = 1.0f;
    }
}

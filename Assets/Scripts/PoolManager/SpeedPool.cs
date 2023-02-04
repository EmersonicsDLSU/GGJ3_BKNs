using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPool : MonoBehaviour
{
    protected string sTagToCompare = "Player";

    private ObjectPool<SpeedPool> _objectPool;

    public void AssignObjectPool(ObjectPool<SpeedPool> objectPool)
    {
        _objectPool = objectPool;
    }

    public GameObject _bloodSplashPrefab;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(sTagToCompare))
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = collision.transform.rotation;
            Vector3 position = contact.point;

            //instantiate a blood splash particle fx
            Instantiate(_bloodSplashPrefab, position, rotation);

            //call speed buff fxn


            _objectPool.ReturnObject(this);
        }
    }
}

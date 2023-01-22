using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tBulletSpawner : MonoBehaviour
{
    [SerializeField] private Transform _locationToSpawn;
    [SerializeField] private Transform _parentTransform;
    [SerializeField] private tBullet _bulletPrefab;

    void Start()
    {
        var objectPool = 
            new tObjectPool<tBullet>(BulletFactoryMethod, TurnOnBullet, TurnOffBullet, 5, true);
    }
    private tBullet BulletFactoryMethod()
    {
        tBullet tempBullet = Instantiate(_bulletPrefab) as tBullet;
        tempBullet.transform.parent = _parentTransform;
        tempBullet.gameObject.SetActive(false);

        return tempBullet;
    }
    private void TurnOnBullet(tBullet bullet)
    {
        bullet.gameObject.SetActive(true);
    }
    private void TurnOffBullet(tBullet bullet)
    {
        bullet.transform.parent = _parentTransform;
        bullet.gameObject.SetActive(false);
    }
}

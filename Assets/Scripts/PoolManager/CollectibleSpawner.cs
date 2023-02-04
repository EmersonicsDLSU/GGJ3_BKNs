using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnLocation;
    [SerializeField] private Transform _sourceLocation;
    [SerializeField] private GameObject _speedPrefab;
    [SerializeField] private GameObject _multPrefab;
    [SerializeField] private GameObject _slowPrefab;

    private ObjectPool<SpeedPool> _speedPool;
    private ObjectPool<MultPool> _multPool;
    private ObjectPool<SlowPool> _slowPool;

    void Start()
    {
        
        if (_spawnLocation == null || _sourceLocation == null)
            Debug.LogError("Missing one or more Transform requirement!");
        // for speed pool
        if (_speedPrefab == null || _speedPrefab.GetComponent<SpeedPool>() == null)
            Debug.LogError("Missing prefab or component!");
        else
        {
            _speedPool = new ObjectPool<SpeedPool>(SpeedFactoryMethod, TurnOnSpeed, TurnOffSpeed, 5, true);
        }
        // for mult pool
        if (_multPrefab == null || _multPrefab.GetComponent<MultPool>() == null)
            Debug.LogError("Missing prefab or component!");
        else
        {
            _multPool = new ObjectPool<MultPool>(MultFactoryMethod, TurnOnMult, TurnOffMult, 5, true);
        }
        // for slow pool
        if (_slowPrefab == null || _slowPrefab.GetComponent<SlowPool>() == null)
            Debug.LogError("Missing prefab or component!");
        else
        {
            _slowPool = new ObjectPool<SlowPool>(SlowFactoryMethod, TurnOnSlow, TurnOffSlow, 5, true);
        }
    }

    // For speed pool
    private SpeedPool SpeedFactoryMethod()
    {
        GameObject obj = Instantiate(_speedPrefab) as GameObject;
        SpeedPool objScript = obj.GetComponent<SpeedPool>();
        // attach a reference of the objectPool to the pool object
        objScript.AssignObjectPool(_speedPool);

        obj.transform.parent = _sourceLocation;
        obj.gameObject.SetActive(false);

        return obj.GetComponent<SpeedPool>();
    }

    private void TurnOnSpeed(SpeedPool speed)
    {
        // parent and reposition(displayed) the recently borrowed pool object
        speed.transform.parent = _spawnLocation;
        speed.transform.position = _spawnLocation.position;

        speed.gameObject.SetActive(true);
    }
    private void TurnOffSpeed(SpeedPool speed)
    {
        // parent and reposition(hidden) the recently borrowed pool object
        speed.transform.parent = _sourceLocation;
        speed.transform.position = _sourceLocation.position;

        speed.gameObject.SetActive(false);
    }
    
    // For Mult pool
    private MultPool MultFactoryMethod()
    {
        GameObject obj = Instantiate(_speedPrefab) as GameObject;
        MultPool objScript = obj.GetComponent<MultPool>();
        // attach a reference of the objectPool to the pool object
        objScript.AssignObjectPool(_multPool);

        obj.transform.parent = _sourceLocation;
        obj.gameObject.SetActive(false);

        return obj.GetComponent<MultPool>();
    }

    private void TurnOnMult(MultPool speed)
    {
        // parent and reposition(displayed) the recently borrowed pool object
        speed.transform.parent = _spawnLocation;
        speed.transform.position = _spawnLocation.position;

        speed.gameObject.SetActive(true);
    }
    private void TurnOffMult(MultPool speed)
    {
        // parent and reposition(hidden) the recently borrowed pool object
        speed.transform.parent = _sourceLocation;
        speed.transform.position = _sourceLocation.position;

        speed.gameObject.SetActive(false);
    }
    
    // For Slow pool
    private SlowPool SlowFactoryMethod()
    {
        GameObject obj = Instantiate(_speedPrefab) as GameObject;
        SlowPool objScript = obj.GetComponent<SlowPool>();
        // attach a reference of the objectPool to the pool object
        objScript.AssignObjectPool(_slowPool);

        obj.transform.parent = _sourceLocation;
        obj.gameObject.SetActive(false);

        return obj.GetComponent<SlowPool>();
    }

    private void TurnOnSlow(SlowPool speed)
    {
        // parent and reposition(displayed) the recently borrowed pool object
        speed.transform.parent = _spawnLocation;
        speed.transform.position = _spawnLocation.position;

        speed.gameObject.SetActive(true);
    }
    private void TurnOffSlow(SlowPool speed)
    {
        // parent and reposition(hidden) the recently borrowed pool object
        speed.transform.parent = _sourceLocation;
        speed.transform.position = _sourceLocation.position;

        speed.gameObject.SetActive(false);
    }

    // functionality for spawning bullet objects
    void Update()
    {

    }
}

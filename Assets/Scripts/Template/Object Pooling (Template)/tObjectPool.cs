using System;
using System.Collections.Generic;

public class tObjectPool<T>
{
    // List of poolable objects
    private readonly List<T> _currentStock;
    // A parameterless function that instantiates a certain class object
    private readonly Func<T> _factoryMethod;

    // List of functions to call when borrowing a poolable
    private readonly Action<T> _turnOnCallback;
    // List of functions to call when returning a poolable
    private readonly Action<T> _turnOffCallback;

    // endless pool if the size is Dynamic
    private readonly bool _isDynamic;

    public tObjectPool(Func<T> factoryMethod, Action<T> turnOnCallback, Action<T> turnOffCallback, int initialStock = 0, bool isDynamic = true)
    {
        _factoryMethod = factoryMethod;
        _isDynamic = isDynamic;

        _turnOffCallback = turnOffCallback;
        _turnOnCallback = turnOnCallback;

        _currentStock = new List<T>();

        for (var i = 0; i < initialStock; i++)
        {
            var o = _factoryMethod();
            _turnOffCallback(o);
            _currentStock.Add(o);
        }
    }
    public tObjectPool(Func<T> factoryMethod, Action<T> turnOnCallback, Action<T> turnOffCallback, List<T> initialStock, bool isDynamic = true)
    {
        _factoryMethod = factoryMethod;
        _isDynamic = isDynamic;

        _turnOffCallback = turnOffCallback;
        _turnOnCallback = turnOnCallback;

        _currentStock = initialStock;
    }
    public T GetObject()
    {
        var result = default(T);
        if (_currentStock.Count > 0)
        {
            result = _currentStock[0];
            _currentStock.RemoveAt(0);
        }
        else if (_isDynamic)
            result = _factoryMethod();
        _turnOnCallback(result);
        return result;
    }

    public void ReturnObject(T o)
    {
        _turnOffCallback(o);
        _currentStock.Add(o);
    }
}
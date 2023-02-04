using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance { get; private set; }

    public int currency { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public void AddCurrency(int value)
    {
        currency += value;
    }
    public void SubtractCurrency(int value)
    {
        currency -= value;
    }

    public int GetCurrency()
    {
        return currency;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            currency++;
            Debug.Log("Currency: " + currency);
        }
    }

}
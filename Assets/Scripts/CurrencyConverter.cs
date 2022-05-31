using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeCurrency
{
    USD,
    EUR,
    CNY
}

public class CurrencyConverter : MonoBehaviour
{

    public TypeCurrency inputCurrencyType;

    public float rub;
    // usd
    // eur
    // cny
    // Convert(100, ...) -> 1.8
    // Start is called before the first frame update
    void Start()
    {
        Convert(rub, inputCurrencyType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float Convert(float rub, TypeCurrency currencyType)
    {
        switch(currencyType)
        {
            case TypeCurrency.USD:
                return rub / 56.97f;
                break;

            default:
                   return -1;
        }

        

        /*switch (currencyType)
        {
            case 0: // USD
            case 0: // USD
                return rub / 56.97f;

                break;
            case 1: // EUR
                return rub / 58.87f;
                break;

            case 2: // CNY
                return rub / 8.71f;
                break;
            default:
                return -1;
                break;
        }*/
    }
}

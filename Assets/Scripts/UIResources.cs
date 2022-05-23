using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Enums;

public class UIResources : MonoBehaviour
{
    [SerializeField] private Text _diamondsCount;
    [SerializeField] private Text _coinsCount;

    public bool ChangeCurrency(CurrencyType currencyType, int value)
    {
        switch (currencyType)
        {
            case CurrencyType.Coin:
                int coinsCountInt = int.Parse(_coinsCount.text);
                coinsCountInt += value;
                if (coinsCountInt < 0)
                {
                    return false;
                }
                _coinsCount.text = coinsCountInt.ToString();
                return true;
            case CurrencyType.Diamond:
                int diamondsCountInt = int.Parse(_diamondsCount.text);
                diamondsCountInt += value;
                if (diamondsCountInt < 0)
                {
                    return false;
                }
                _diamondsCount.text = diamondsCountInt.ToString();
                return true;
            default:
                return true;
        }
    }
}

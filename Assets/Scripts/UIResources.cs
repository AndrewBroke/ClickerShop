using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIResources : MonoBehaviour
{
    [SerializeField] private Text _diamondsCount;
    [SerializeField] private Text _coinsCount;

    public void AddCoins(int n)
    {
        int coinsCountInt = int.Parse(_coinsCount.text);
        coinsCountInt += n;
        _coinsCount.text = coinsCountInt.ToString();
    }

    public bool RemoveCoins(int n)
    {
        int coinsCountInt = int.Parse(_coinsCount.text);
        coinsCountInt -= n;
        if (coinsCountInt < 0)
        {
            return false;
        }

        

        _coinsCount.text = coinsCountInt.ToString();

        return true;
    }

    public void AddDiamonds(int n)
    {
        int diamondsCountInt = int.Parse(_diamondsCount.text);
        diamondsCountInt += n;
        _diamondsCount.text = diamondsCountInt.ToString();
    }
}

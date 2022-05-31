using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum ItemType
    {
        None = -1,
        Diamond = 0,
        Sword = 1,
        Book = 2,
        Potion = 3
    }

    public enum CurrencyType
    {
        Coin = 0,
        Diamond = 1
    }
}

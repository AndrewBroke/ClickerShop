using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Enums;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemType _itemType;
    [SerializeField] private UIResources _uIResources;
    [SerializeField] private CurrencyType _currencyType;
     
    private int _cost;
    private int _count;

    public ItemType GetItemType()
    {
        return _itemType;
    }

    private void Start()
    {
        
        _cost = int.Parse(GameObject.Find(gameObject.name + "/Cost/CostCount").gameObject.GetComponent<Text>().text);
        _count = int.Parse(GameObject.Find(gameObject.name + "/ProductCount").gameObject.GetComponent<Text>().text);
    }

    public void Click()
    {
        switch (_itemType)
        {
            case ItemType.Diamond:
                if (_uIResources.ChangeCurrency(CurrencyType.Coin, -_cost))
                {
                    _uIResources.ChangeCurrency(CurrencyType.Diamond, _count);
                }
                break;
            case ItemType.Item:

                break;

            default:

                break;
        }

    }
}

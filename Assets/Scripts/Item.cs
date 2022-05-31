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
    private Inventory _inventory;
    private Sprite _productImage;

    public ItemType GetItemType()
    {
        return _itemType;
    }

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        _productImage = GameObject.Find(gameObject.name + "/ProductImage").gameObject.GetComponent<Image>().sprite;
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
            default:
                if (_uIResources.ChangeCurrency(_currencyType, -_cost))
                {
                    _inventory.AddItem(_itemType, _count, _productImage);

                    Debug.Log("Куплен " + gameObject.name);
                }
                break;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Enums;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemType _type;
    [SerializeField] private UIResources _uIResources;
     
    private int _cost;
    private int _count;

    public ItemType GetItemType()
    {
        return _type;
    }

    private void Start()
    {
        
        _cost = int.Parse(GameObject.Find(gameObject.name + "/Cost/CostCount").gameObject.GetComponent<Text>().text);
        _count = int.Parse(GameObject.Find(gameObject.name + "/ProductCount").gameObject.GetComponent<Text>().text);
    }

    public void Click()
    {
        switch (_type)
        {
            case ItemType.Diamond:
                if (_uIResources.RemoveCoins(_cost))
                {
                    _uIResources.AddDiamonds(_count);
                }
                break;
            case ItemType.Item:

                break;

            default:

                break;
        }

    }
}

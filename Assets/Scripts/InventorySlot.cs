using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Enums;

public class InventorySlot : MonoBehaviour
{
    private Text _count;
    private ItemType _type;
    private GameObject _countObject;
    private Image _itemImage;
    // Start is called before the first frame update
    void Start()
    {
        _itemImage = GameObject.Find(gameObject.name + "/ItemImage").GetComponent<Image>();
        _countObject = gameObject.transform.Find("Count").gameObject;
        _count = _countObject.GetComponent<Text>();
        _type = ItemType.None;
        _count.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Add(ItemType type, int count, Sprite sprite)
    {
        if(_type == ItemType.None)
        {
            _count.text = (int.Parse(_count.text) + count).ToString();
            _countObject.SetActive(true);
            _type = type;
            _itemImage.sprite = sprite;
        }
        else if (_type == type)
        {
            if(int.Parse(_count.text) + count >= 10)
            {
                return false;
            }
            _count.text = (int.Parse(_count.text) + count).ToString();
        }
        else
        {
            return false;
        }
        return true;
    }
}

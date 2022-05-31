using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

public class Inventory : MonoBehaviour
{
    private List<InventorySlot> _inventorySlots;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] slotsObjects = GameObject.FindGameObjectsWithTag("Inventory Slot");
        _inventorySlots = new List<InventorySlot>();

        // Создаем список из слотов
        foreach (var slot in slotsObjects)
        {
            InventorySlot currentInventorySlot = slot.GetComponent<InventorySlot>();
            _inventorySlots.Add(currentInventorySlot);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(ItemType type, int count, Sprite sprite)
    {
        for (int i = 0; i < _inventorySlots.Count; i++)
        {
            if (_inventorySlots[i].Add(type, count, sprite))
            {
                return;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton

    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    Item[] currentItem;

    public void Start()
    {
        int numSlot = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentItem = new Item[numSlot];
    }

    public void Equip(Item newItem)
    {
        int slotIndex = (int)newItem.slot;

        currentItem[slotIndex] = newItem;
    }
}

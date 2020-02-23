using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/BaseItem")]
public class Item : ScriptableObject
{
    public EquipmentSlot slot;

    public int hpBonus;
    public int attBonus;
    public int defBonus;

    public void Use()
    {
        EquipmentManager.instance.Equip(this);
    }
}

public enum EquipmentSlot { Arme, Armure, Objet}

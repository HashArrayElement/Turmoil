using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute(menuName = "Item")]
public class Item : ScriptableObject
{
    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary,
        Unknown
    }
    public string itemName = "Item";
}

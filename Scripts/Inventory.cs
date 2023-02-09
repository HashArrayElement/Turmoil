using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Gun[] guns = new Gun[2];

    public Item[] items;

    public Backpack bag;

    private float maxItemCount;

    public void PickupGun(Gun gun)
    {
       if(guns[1] == null) guns[1] = gun; else guns[2] = gun;
    }
    public void DropGun(int index)
    {
        guns[index] = null;
    }
    public void PickupBackpack(Backpack backpack)
    {
        bag = backpack;
        maxItemCount = bag.itemCapacity;
    }
    public void DropBackpack()
    {
        bag = null;
    }
    private void PickupItem(Item item)
    {
        items[items.Length + 1] = item;
    }
    private void DropItem(int index)
    {
        items[index] = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        Inventory.instance.Add(item);   // Add to inventory

        Destroy(gameObject);    // Destroy item from scene
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public float speed;
    public GameObject InventoryUI;
    //public GameObject QuestList;
    public GameObject CabinetInventory;

    public void OpenInventory() {
        Debug.Log("open inventory");
        InventoryUI.SetActive(true);
    }

    public void CloseInventory() {
        Debug.Log("Inventory closed");
        InventoryUI.SetActive(false);
    }

    public void CloseCabinetInventory() {
        Debug.Log("Cabinet Inventory closed");
        CabinetInventory.SetActive(false);
    }
}

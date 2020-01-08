using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject InventoryUI;

    public void OpenInventory() {
        Debug.Log("open inventory");
        InventoryUI.SetActive(true);
    }

    public void CloseInventory() {
        Debug.Log("closed inventory");
        InventoryUI.SetActive(false);
    }
}

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
    public GameObject GroundElevator;
    public GameObject SecElevator;
    public GameObject ThrElevator;
    public GameObject Player;

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

    public void CloseGroundElevator() {
        Debug.Log("GroundElevator closed");
        GroundElevator.SetActive(false);
    }

    public void CloseSecElevator() {
        Debug.Log("SecElevator closed");
        SecElevator.SetActive(false);
    }

    public void CloseThrElevator() {
        Debug.Log("ThrElevator closed");
        ThrElevator.SetActive(false);
    }

    public void TeleportToG() {
        Player.transform.position = new Vector3(6.71f, 0.21f, -0.75f);
        SecElevator.SetActive(false);
        ThrElevator.SetActive(false);
    }

    public void TeleportToSec() {
        Player.transform.position = new Vector3(6.71f, 4.15f, -0.75f);
        GroundElevator.SetActive(false);
        ThrElevator.SetActive(false);
    }

    public void TeleportToThr() {
        Player.transform.position = new Vector3(6.71f, 7.99f, -0.75f);
        GroundElevator.SetActive(false);
        SecElevator.SetActive(false);
    }
}

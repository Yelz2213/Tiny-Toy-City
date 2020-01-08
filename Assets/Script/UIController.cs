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
    public GameObject content;
    public GameObject button_continue;
    public GameObject button_end;
    public Text name;
    public Text content_Text;
    public int count = 0;

    public void Start()
    {
        button_end.SetActive(false);
    }

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

    //Elevator func.
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

    public void EndtheConversation()
    {
        content.SetActive(false);
    }

    public void Conversation()
    {
        count++;
        switch (count) {
            case 1:
                name.text = "Mr.Capsule";
                content_Text.text = "Hi, I am Capsule, I booked a room at 8p.m.";
                break;
            case 2:
                name.text = "Mr.Cylinder";
                content_Text.text = "Welcome! Mr.Capsult, the fee of double bed room is cost $500.";
                break;
            case 3:
                name.text = "Mr.Capsule";
                content_Text.text = "All right. Check in please.";
                break;
            case 4:
                name.text = "Mr.Cylinder";
                content_Text.text = "Here is you keycard. Your room is located at left hand side of second floor";
                content.SetActive(false);
                break;
        }

        if (count > 4)
        {
            content.SetActive(true);
            button_continue.SetActive(false);
            button_end.SetActive(true);
            name.text = "Mr.Capsule";
            content_Text.text = "I don't need to find reception anymore.";
        }



    }
}

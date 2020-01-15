using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public float speed;
    public int money;
    //Script declare
    C_Controller c_controller;

    //UI declare
    public GameObject InventoryUI;
    public GameObject CabinetInventory;
    public GameObject GroundElevator;
    public GameObject SecElevator;
    public GameObject ThrElevator;
    public GameObject player_cap;
    public GameObject content;
    public GameObject button_continue;
    public GameObject button_continue2;
    public GameObject button_continue3;
    public GameObject button_end;
    public Text money_text;
    public Text name;
    public Text content_Text;
    public int Ccount = 0;
    public int Qcount = 0;
    public int QRcount = 0;
    public GameObject questionList;

    //Item
    public bool hasKeycard;
    public bool hasSuit;
    public bool changedSuit = false;
    public bool hasKey;
    public GameObject keycard_slot;
    public GameObject suit_slot;

    //Audio declare
    public AudioSource buttonClick;
    public AudioSource elevatorSound;
    public AudioSource npcSound;

    //Material
    public Material suit;
    public Texture suit_texture;

    //Renderer
    public MeshRenderer pplayer;

    public void Start()
    {
        button_end.SetActive(false);
        c_controller = GetComponent<C_Controller>();

        money = 500;
        hasKeycard = false;
        hasSuit = true;
        changedSuit = false;
        hasKey = false;

    }

    private void Update()
    {
        money_text.text = money.ToString();
    }

    //Inventory UI
    public void OpenInventory() {
        Debug.Log("open inventory");
        InventoryUI.SetActive(true);
        buttonClick.Play();
    }

    public void CloseInventory() {
        Debug.Log("Inventory closed");
        InventoryUI.SetActive(false);
        buttonClick.Play();
    }

    public void CloseCabinetInventory() {
        Debug.Log("Cabinet Inventory closed");
        CabinetInventory.SetActive(false);
        buttonClick.Play();
    }

    public void useSuit() {
        if (hasSuit == true)
        {
            Debug.Log("changing");
            player_cap.SetActive(true);
            pplayer.material = suit;

            hasSuit = false;
            changedSuit = true;

            if (changedSuit == true) {
                Debug.Log("suit changed");
                    }
        }
        suit_slot.SetActive(false);
    }

    //Elevator part
    public void CloseGroundElevator() {
        Debug.Log("GroundElevator closed");
        GroundElevator.SetActive(false);
        buttonClick.Play();
    }

    public void CloseSecElevator() {
        Debug.Log("SecElevator closed");
        SecElevator.SetActive(false);
        buttonClick.Play();
    }

    public void CloseThrElevator() {
        Debug.Log("ThrElevator closed");
        ThrElevator.SetActive(false);
        buttonClick.Play();
    }

    //Elevator func.
    public void TeleportToG() {
        player_cap.transform.position = new Vector3(6.71f, 0.21f, -0.75f);
        SecElevator.SetActive(false);
        ThrElevator.SetActive(false);
        elevatorSound.Play();
    }

    public void TeleportToSec() {
        player_cap.transform.position = new Vector3(6.71f, 4.15f, -0.75f);
        GroundElevator.SetActive(false);
        ThrElevator.SetActive(false);
        elevatorSound.Play();
    }

    public void TeleportToThr() {
        player_cap.transform.position = new Vector3(6.71f, 7.99f, -0.75f);
        GroundElevator.SetActive(false);
        SecElevator.SetActive(false);
        elevatorSound.Play();
    }

    public void EndtheConversation()
    {
        content.SetActive(false);
        buttonClick.Play();
    }

    public void Conversation()
    {
        buttonClick.Play();
        Ccount++;
        switch (Ccount) {
            case 1:
                name.text = "Mr.Capsule";
                content_Text.text = "Hi, I am Capsule, I booked a room at 8p.m.";
                break;
            case 2:
                name.text = "Mr.Cylinder";
                content_Text.text = "Welcome! Mr.Capsult, the fee of double bed room is cost $500.";
                npcSound.Play();
                break;
            case 3:
                name.text = "Mr.Capsule";
                content_Text.text = "All right. Check in please.";
                money = 0;
                break;
            case 4:
                name.text = "Mr.Cylinder";
                content_Text.text = "Here is you keycard. Your room is located at left hand side of second floor";
                hasKeycard = true;
                keycard_slot.SetActive(true);

                npcSound.Play();
                break;
            case 5:
                name.text = "Mr.Capsule";
                content_Text.text = "Thank you.";
                break;
            case 6:
                content.SetActive(false);
                break;
        }

        if (Ccount > 6)
        {
            content.SetActive(true);
            button_continue.SetActive(false);
            button_end.SetActive(true);
            name.text = "Mr.Capsule";
            content_Text.text = "I don't need to find reception anymore.";
        }

    }

    public void Question() {
        buttonClick.Play();
        Qcount++;
        switch (Qcount)
        {
            case 1:
                name.text = "Mr.Capsule";
                content_Text.text = "Hi, Mr.Evil.";
                break;
            case 2:
                name.text = "Mr.Capsule";
                content_Text.text = "I am Joker, just look at my suit";
                money = 0;
                break;
            case 3:
                name.text = "Mr.Evil";
                content_Text.text = "You should know the password, right?";
                questionList.SetActive(true);
                npcSound.Play();
                break;
        }
    }

    public void QuestionRight() {
        QRcount++;
        switch (QRcount)
        {
            case 1:
                questionList.SetActive(false);
                content_Text.text = "Great. The list is hidden in the 3rd floor. And you need find out the key to open it.";
                button_continue.SetActive(false);
                button_continue2.SetActive(false);
                button_continue3.SetActive(true);
                break;
            case 2:
                name.text = "Mr.Capsule";
                content_Text.text = "Where is the key?";
                break;
            case 3:
                name.text = "Mr.Evil";
                content_Text.text = "Hidden in the box in the 3rd floor too, but I forgot which box.";
                break;
            case 4:
                name.text = "Mr.Capsule";
                content_Text.text = "...";
                button_continue3.SetActive(false);
                button_end.SetActive(true);
                break;
        }
    }
}

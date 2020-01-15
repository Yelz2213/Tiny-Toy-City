using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointClick : MonoBehaviour
{
    //Script declare
    DialogueTrigger dialogueTriggle;
    OutlineTrigger outlineTrigger;
    C_Controller c_controller;
    UIController uicontroller;
    ChangeScene changescene;

    public GameObject cabinetInventoryUI;
    public GameObject groundElevatorUI;
    public GameObject secElevatorUI;
    public GameObject thrElevatorUI;
    public GameObject content;
    public Text name;
    public Text content_Text;
    public GameObject Key_slot;
    //Mr.cylinder
    public GameObject conti;
    //Mr.Evil
    public GameObject conti2;
    public GameObject conti3;
    public GameObject end;
    public GameObject door_model;
    public GameObject gate1_model;
    public GameObject gate2_model;

    //Audio
    public AudioSource npcSound;

    //Amin
    public Animator door;
    public Animator gate1;
    public Animator gate2;

    //script
    public GameObject checkitem;

    private void Start()
    {
        door = door_model.GetComponent<Animator>();
        gate1 = gate1_model.GetComponent<Animator>();
        gate2 = gate2_model.GetComponent<Animator>();
        uicontroller = checkitem.GetComponent<UIController>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform != null)
                {
                    //cabinet
                    if (hit.transform.name == "cabinet") {
                        cabinetInventoryUI.SetActive(true);
                    }

                    //2nd door
                    if (hit.transform.name == "Box_Door") {
                        if (uicontroller.hasKeycard == true){
                            door.Play("Door");
                        }
                        else
                        {
                            name.text = "Mr.Capsule";
                            content.SetActive(true);
                            content_Text.text = "I have to get the keycard first.";
                            conti.SetActive(false);
                            end.SetActive(true);
                        }
                    }

                    //3rd Box
                    if (hit.transform.name == "CarboardBox_1(Physics)" || hit.transform.name == "CarboardBox_3(Physics)") {
                        name.text = "Mr.Capsule";
                        content.SetActive(true);
                        content_Text.text = "Not this one.";
                        conti.SetActive(false);
                        end.SetActive(true);
                    }

                    //3rd gate
                    if (hit.transform.name == "gate1_2_gate_LOD_0" || hit.transform.name == "gate1_2_gate_LOD1") {
                        if (uicontroller.hasKey == true)
                        {
                            gate1.Play("Gate");
                            gate2.Play("Gate2");
                        }
                    }

                    if (hit.transform.name == "Chest")
                    {
                        if (uicontroller.hasKey == true)
                        {
                            SceneManager.LoadScene(4);
                        }
                    }

                    if (hit.transform.name == "CarboardBox_2(Physics)")
                    {
                        name.text = "Mr.Capsule";
                        content.SetActive(true);
                        content_Text.text = "Bingo.";
                        conti.SetActive(false);
                        end.SetActive(true);
                        uicontroller.hasKey = true;
                        Key_slot.SetActive(true);
                    }

                    //NPC : Mr.Cylinder
                    if (hit.transform.name == "NPC_Cylinder") {
                        name.text = "Mr.Cylinder";
                        content.SetActive(true);
                        content_Text.text = "Welcome to Tiny Toy hotel. How may I help you ?";
                        npcSound.Play();
                        conti.SetActive(true);
                        end.SetActive(false);
                    }

                    //NPC : Mr.Unknown
                    if (hit.transform.name == "NPC_Unknown")
                    {
                        name.text = "Mr.Unknown";
                        content.SetActive(true);
                        content_Text.text = "The tangram behind me is representing our organization";
                        npcSound.Play();
                        conti.SetActive(false);
                        end.SetActive(true);
                    }

                    //NPC : Mr.Evil
                    if (hit.transform.name == "NPC_Evil") {
                        Debug.Log(uicontroller.Qcount);
                        if(uicontroller.Qcount > 3)
                        {
                            name.text = "Mr.Evil";
                            content.SetActive(true);
                            content_Text.text = "Nothing to say.";
                            npcSound.Play();
                            conti2.SetActive(false);
                            end.SetActive(true);
                        }
                        if (uicontroller.changedSuit == true) {
                            Debug.Log("he knew who you are.");
                            name.text = "Mr.Evil";
                            content.SetActive(true);
                            content_Text.text = "Who are you ?";
                            npcSound.Play();
                            conti2.SetActive(true);
                            end.SetActive(false);
                        } else {
                            name.text = "Mr.Evil";
                            content.SetActive(true);
                            content_Text.text = "Who are you ?";
                            npcSound.Play();
                            conti2.SetActive(false);
                            end.SetActive(true);
                        }


                    }

                    if (hit.transform.name == "PhotoFrame_Rabbit")
                    {
                        name.text = "Mr.Capsule";
                        content.SetActive(true);
                        content_Text.text = "It is a rabbit.";
                        conti.SetActive(false);
                        end.SetActive(true);

                    }
                    if (hit.transform.name == "PhotoFrame_Horse")
                    {
                        name.text = "Mr.Capsule";
                        content.SetActive(true);
                        content_Text.text = "It is a horse.";
                        conti.SetActive(false);
                        end.SetActive(true);
                    }
                    if (hit.transform.name == "PhotoFrame_Fox")
                    {
                        name.text = "Mr.Capsule";
                        content.SetActive(true);
                        content_Text.text = "It is a fox.";
                        conti.SetActive(false);
                        end.SetActive(true);
                    }

                    if (hit.transform.name == "Elevator_ground"){

                        groundElevatorUI.SetActive(true);
                    }

                    if (hit.transform.name == "Elevator_2nd") {
                        secElevatorUI.SetActive(true);
                    }

                    if (hit.transform.name == "Elevator_3rd") {
                        thrElevatorUI.SetActive(true);
                    }
                }

            }
        }
    }

    private void printName(GameObject go) {
        print(go.name);
    }


}

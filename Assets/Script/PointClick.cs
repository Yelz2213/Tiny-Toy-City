using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointClick : MonoBehaviour
{
    OutlineTrigger outlineTrigger;
    public GameObject cabinetInventoryUI;
    public GameObject groundElevatorUI;
    public GameObject secElevatorUI;
    public GameObject thrElevatorUI;
    public GameObject content;
    public Text name;
    public Text content_Text;
    public GameObject conti;
    public GameObject end;
    DialogueTrigger dialogueTriggle;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    if (hit.transform.name == "cabinet") {
                        cabinetInventoryUI.SetActive(true);
                    }

                    if (hit.transform.name == "NPC_Cylinder") {
                        content.SetActive(true);
                        name.text = "Mr. Cylinder";
                        content_Text.text = "Welcome to Tiny Toy hotel. How may I help you ?";
                        conti.SetActive(true);
                        end.SetActive(false);
                    }

                    if(hit.transform.name == "Elevator_ground"){

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointClick : MonoBehaviour
{
    OutlineTrigger outlineTrigger;
    public GameObject cabinetInventoryUI;

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
                    printName(hit.transform.gameObject);
                }
            }
        }
    }

    private void printName(GameObject go) {
        print(go.name);
    }


}

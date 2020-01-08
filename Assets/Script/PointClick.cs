using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointClick : MonoBehaviour
{
    OutlineTrigger outlineTrigger;
    public GameObject InventoryUI;

    private void OnClick()
    {
        if (outlineTrigger.isTriggering == true) {
            Debug.Log("Clicking");
            InventoryUI.SetActive(true);
        }
    }


}

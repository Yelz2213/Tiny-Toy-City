using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class OutlineTrigger : MonoBehaviour
{
    private Outline outline;

    void Start() {
        outline = GetComponent<Outline>();
    }

    public bool isTriggering = false;

    void OnMouseEnter()
    {
        if (isTriggering == true)
        {
            outline.enabled = true;
        }
    }

    private void OnMouseExit()
    {
            outline.enabled = false;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            isTriggering = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTriggering = false;
        }
    }

}

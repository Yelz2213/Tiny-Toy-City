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

    bool isTriggering = false;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            isTriggering = true;
            outline.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTriggering = false;
            outline.enabled = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Controller : MonoBehaviour
{
    OutlineTrigger outlineTrigger;
    UIController uicontroller;

    //Speed of movement
    public float Speed;

    private void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement() {
        //front & back
        float hor = Input.GetAxis("Horizontal");
        //left and right
        float ver = Input.GetAxis("Vertical");

        //Movement
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}

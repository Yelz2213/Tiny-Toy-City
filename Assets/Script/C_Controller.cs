using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Controller : MonoBehaviour
{
    //Speed of movement
    public float Speed;
    OutlineTrigger outlineTrigger;

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

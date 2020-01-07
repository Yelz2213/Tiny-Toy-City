using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Controller : MonoBehaviour
{
    public float Speed;


    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement() {
        //front & back
        float hor = Input.GetAxis("Horizontal");
        //left and right
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}

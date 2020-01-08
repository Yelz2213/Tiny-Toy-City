using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Controller : MonoBehaviour
{
    //Speed of movement
    public float Speed;
    OutlineTrigger outlineTrigger;
    public int money;
    public Text Text_money;

    private void Start()
    {
        money = 500;
        Text_money.text = "";
    }

    void Update()
    {
        Text_money.text = money.ToString();
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

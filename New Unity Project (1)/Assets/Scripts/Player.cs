using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
    public GameObject player;
    public Transform left;
    public Transform right;
    public float JumpSpeed;
    public GameObject BtnRight;
    public GameObject BtnLeft;
    float PosBtnLeft;
    float PosBtnRight;
    public float run;

    private void Start()
    {
        PosBtnRight = BtnRight.transform.position.y;
        PosBtnLeft = BtnLeft.transform.position.y;

    }
    private void Update()
    {


        if (Input.GetKey(KeyCode.A)|| (PosBtnLeft != BtnLeft.transform.position.y))
        {

            transform.Translate(Vector3.forward * run * Time.deltaTime);
             transform.LookAt(left);
        }
        if (Input.GetKey(KeyCode.D)|| (PosBtnRight != BtnRight.transform.position.y))
        {
            
                transform.Translate(Vector3.forward * run * Time.deltaTime);
                transform.LookAt(right);
        }


        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += player.transform.position * JumpSpeed;
        }


    }

}


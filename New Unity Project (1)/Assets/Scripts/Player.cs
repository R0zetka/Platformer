using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
   
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


        if (Input.GetKey(KeyCode.D)|| (PosBtnLeft != BtnLeft.transform.position.y))
        {
            transform.Translate(Vector3.back * run * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)|| (PosBtnRight != BtnRight.transform.position.y))
        {
               transform.Translate(Vector3.forward * run * Time.deltaTime);
        }






    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Player : MonoBehaviour
{
    public GameObject player;
    public Transform left;
    public Transform right;
   
    public GameObject BtnRight;
    public GameObject BtnLeft;
    float PosBtnLeft;
    float PosBtnRight;
    public float run;

    public bool IsGround;
    public float JumpSpeed;
    private Rigidbody rb;



    private void Start()
    {
        PosBtnRight = BtnRight.transform.position.y;
        PosBtnLeft = BtnLeft.transform.position.y;

    }
    private void Update()
    {
        Jump();

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


      


    }
    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast(ray,out rh, 1f))
        {
            IsGround = true;
        }
        else
        {
            IsGround = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && IsGround == true)
        {
            transform.Translate(Vector3.up * JumpSpeed );
            // player.transform.position = transform.position * JumpSpeed;
        }
       
    }

}


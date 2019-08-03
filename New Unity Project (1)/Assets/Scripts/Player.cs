using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject BtnRight;
    public GameObject BtnLeft;
    float PosBtnLeft;
    float PosBtnRight;
    float run;

    private void Start()
    {
        PosBtnRight = BtnRight.transform.position.y;
        PosBtnLeft = BtnLeft.transform.position.y;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (PosBtnLeft != BtnLeft.transform.position.y)
        {
            run = -3f;
        }else if(PosBtnRight != BtnRight.transform.position.y)
        {
            run = 3f;
        }
        else
        {
            run = 0f;
        }
        rb.velocity = new Vector2(run, rb.velocity.y);
    }
}


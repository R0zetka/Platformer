using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using CnControls;

public class Player : MonoBehaviour
{
    public float speed;
    public float speedJump;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        


    }
}                                                       


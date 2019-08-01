using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed;//скорость персонажа
    public float speedJump;//сила прыжка
    public float gravityForce; // гравитация персонажа
    public Vector3 moveVector; // направление движения персонажа

    // ссылка на компоненты
    private CharacterController ch_controller;
    private Animator ch_animator;




    public GameObject player;//персонаж

    // Use this for initialization
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
    }
    //метод перемещения
    private void CharacterMove()
    {
        //перемещение
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.y = gravityForce;

        ch_controller.Move(moveVector * Time.deltaTime);// метод движения персонажа по  направлению


    }

    //метод гравитации
    private void GamingGravity()
    {
        if (!ch_controller.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        }
        else
        {
            gravityForce = -1f;
        }
    }



}                                                       


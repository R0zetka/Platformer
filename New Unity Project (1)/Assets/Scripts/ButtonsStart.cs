using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsStart : MonoBehaviour
{

     void Start()
    {
       
    }

    void OnMouseUpAsButton()
    {
        Application.LoadLevel("Level1");
    }
}

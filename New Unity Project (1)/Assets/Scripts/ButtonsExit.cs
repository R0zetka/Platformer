using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsExit : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        Application.Quit();
    }
}

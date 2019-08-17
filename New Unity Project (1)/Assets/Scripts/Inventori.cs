using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventori : MonoBehaviour
{
    public GameObject Button;
    float Button1;
    public Camera Camera1;
    public Camera Camera2;
    // Start is called before the first frame update
    void Start()
    {
        Button1 = Button.transform.position.y;
        Camera1.enabled = true;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Button1 != Button.transform.position.y)
        {
            Camera1.enabled = !Camera1.enabled;
            Camera2.enabled = !Camera2.enabled;
        }
    }
    
}

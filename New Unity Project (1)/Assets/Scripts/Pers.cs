using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pers : MonoBehaviour
{
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
       if (Score < 1)
        {
            Score++;
           
                Application.LoadLevel("Character");


        }
        //    PlayerPrefs.GetInt("score", Score);
        // Score;
    }

   
    void Update()
    {
        
    }
}

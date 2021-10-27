using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        this.GetComponent<Animator>().Play("Start_Game");
        if (Input.GetKey(KeyCode.Escape))
        this.GetComponent<Animator>().Play("Game_Start");
    }
}

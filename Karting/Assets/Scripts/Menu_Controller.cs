using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Controller : MonoBehaviour
{

    public int state = 1;
    // 1 = Start; 2 = Play; 3 = Game; 4 = Pause
    void Update()
    {
        //folosim getkeydown la animatiile cu vecine care folosesc aceeasi tasta pentru tranzitie ca sa nu se playeze deodata
        if (Input.GetKeyDown(KeyCode.Space) && state == 2)
        {
        this.GetComponent<Animator>().Play("Play_Game");
        state = 3;
        }
        else if (Input.GetKey(KeyCode.Space) && state == 1)
        {
        this.GetComponent<Animator>().Play("Start_Play");
        state = 2;
        }
        else if (Input.GetKey(KeyCode.Escape) && state == 2)
        {
        this.GetComponent<Animator>().Play("Play_Start");
        state = 1;
        }
        else if (Input.GetKey(KeyCode.Escape) && state == 3)
        {
        this.GetComponent<Animator>().Play("Game_Pause");
        state = 4;
        } 
        else if (Input.GetKeyDown(KeyCode.Escape) && state == 4)
        {
        this.GetComponent<Animator>().Play("Pause_Start");
        state = 1;
        } 
        else if (Input.GetKey(KeyCode.Space) && state == 4)
        {
        this.GetComponent<Animator>().Play("Pause_Game");
        state = 3;
        } 
    }
}

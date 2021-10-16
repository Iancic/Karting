using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kart2 : MonoBehaviour
{
    Rigidbody CorpRigid;
    public float thrust;
    private float rotation_y;
    public float rotation_thrust;

    // Start is called before the first frame update
    void Start()
    {
        CorpRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation_y = transform.eulerAngles.y; 
        
        if (Input.GetKey(KeyCode.U))
        {
        CorpRigid.drag = 1;
        }
        
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {   
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.forward * thrust);
            CorpRigid.AddForce(Vector3.right * thrust);
            if (rotation_y < 45 || rotation_y > 225)
            {
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);
            }
            if (rotation_y > 45 && rotation_y < 225)
            {
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
            }
        }

        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {   
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.back * thrust);
            CorpRigid.AddForce(Vector3.right * thrust);
            if (rotation_y < 135)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 135)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {   
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.back * thrust);
            CorpRigid.AddForce(Vector3.left * thrust);
            if (rotation_y < 225)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 225)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {   
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.forward * thrust);
            CorpRigid.AddForce(Vector3.left * thrust);
            if (rotation_y < 315 && rotation_y > 135)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 315 || rotation_y < 135)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }

        else if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.left * thrust);
            if (rotation_y < 270 && rotation_y > 90)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 270 || rotation_y < 90)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }
 
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.forward * thrust);
            if (rotation_y > 1 && rotation_y > 180)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 1 && rotation_y < 180)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.back * thrust);
            if (rotation_y < 180)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);

            if (rotation_y > 180)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            CorpRigid.drag = 0;
            CorpRigid.AddForce(Vector3.right * thrust);
            if (rotation_y < 270 && rotation_y > 90)
            this.transform.Rotate(new Vector3(0,-15f,0) * rotation_thrust);

            if (rotation_y > 270 || rotation_y < 90)
            this.transform.Rotate(new Vector3(0,15f,0) * rotation_thrust);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(2,7,0.5f)); //moviendo op1

        if (Input.GetKey(KeyCode.Q)){
            transform.Translate(new Vector3(0,0,10f*Time.deltaTime)); //mover op2
        }

        else if(Input.GetKeyDown(KeyCode.X)){
            transform.Rotate(0,-1f,0); //rotación
        }
    }
}

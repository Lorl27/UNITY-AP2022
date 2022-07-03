using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase7 : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody player;
    public float velocidad=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    if (Input.GetKey(KeyCode.Q)){
        Debug.Log("Apretando la Q");
        player.AddForce(0,0,velocidad*Time.deltaTime);
    }

    else if(Input.GetKey(KeyCode.E)){
        Debug.Log("Apretando la E");
        player.AddForce(0,0,-velocidad*Time.deltaTime);
    }

    }
}    
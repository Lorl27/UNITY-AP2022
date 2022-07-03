using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 inicioP;
    void Start()
    {
        inicioP=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10 || Input.GetKey(KeyCode.T)){
            Respawn();
        }

        void Respawn(){
            transform.position=inicioP;
        }
    }
}
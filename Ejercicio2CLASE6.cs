using System.Collections;
using UnityEngine;


    public class Ejercicio2CLASE6 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { //movimientos X - Y - Z

        if (Input.GetKey(KeyCode.D)) //derecha
        {
            transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
        }

        else if (Input.GetKey(KeyCode.A)) //izquierda
        {
            transform.Translate(-10 * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.S))    //abajo
        {
            transform.Translate(0, -10, 0);
        }

        else if (Input.GetKey(KeyCode.W)) //arriba
        {
            transform.Translate(0, 10, 0);
        }

        }
    }

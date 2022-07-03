using System.Collections;
using UnityEngine;


    public class Ejercicio1CLASE6 : MonoBehaviour
    {
        int edad = 17;
        // Use this for initialization
        void Start()
        {
            
            if (edad>= 18)
            {
                Debug.Log("Podés conducir, sos mayor de edad");
            }
            else
            {
                Debug.Log("Aún no podés conducir");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

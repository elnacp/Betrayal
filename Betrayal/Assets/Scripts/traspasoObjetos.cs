using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traspasoObjetos : MonoBehaviour {




    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "Llave":
                 //Primero comprueba que el trigger este activado
                 //Pone el dialogo de muchas gracias         

                break;
        }    
    }
}

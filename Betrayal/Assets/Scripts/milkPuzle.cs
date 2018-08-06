using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkPuzle : MonoBehaviour {

    public GameObject pieza; // pieza q colisiona
    public GameObject casilla; // casilla dnde tiene que ir la pieza
    public GameObject show;  // pieza que se tiene que mostrar
    private bool destruir = false;
    public GameObject acomuladorPiezas;
    public bool isInside = false;


    private void Update()
    {
        if (destruir == true)
        {
            Destroy(pieza);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!variablesGlobals.finalPartida)
        {
            if (other.name == casilla.name)
            {
                if (!isInside)
                {
                    show.SetActive(true);
                    destruir = true;
                    acomuladorPiezas.GetComponent<AcomuladorPiezas>().aumentarAcomulador();
                    isInside = true;
                }

            }
        }
        
    }


}

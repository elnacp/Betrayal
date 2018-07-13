using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkPuzle : MonoBehaviour {

    public GameObject pieza; // pieza q colisiona
    public GameObject casilla; // casilla dnde tiene que ir la pieza
    public GameObject show;  // pieza que se tiene que mostrar
    private bool destruir = false;

    public GameObject objecte;
    private acumuladorPuzle acum;
    private int num;

   



    private void Update()
    {
        if (destruir == true)
        {
            Destroy(pieza);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == casilla.name)
        {
            show.SetActive(true);
            destruir = true;

            objecte.GetComponent<acumuladorPuzle>().acomulador++;
            objecte.GetComponent<acumuladorPuzle>().entro = true;
   
        }
    }


}

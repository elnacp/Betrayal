using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//REGISTRA QUE TECLA DEL TECLADO ESTA TOCANDO EL JUGADOR
public class tecla : MonoBehaviour {

    public GameObject teclado; // tecla
    public bool isInside = false; // si esta dentro del
    public GameObject audioPanel;


    private void OnTriggerStay(Collider other)
    {
        if ( other.tag == "hand")  // mira si el colisionador es una mano
        {
            if (OVRInput.Get(OVRInput.Button.One)) // comprueba si se mantiene dentro y clica la A si no se clicará el número
            {
                if (!isInside){  // solo le pasa el número si no ha clicado con anterioridad
                    audioPanel.GetComponent<PanelAudio>().ClickCode();
                    teclado.GetComponent<panelNumeros>().rebreCodi(gameObject);  // envia la tecla al scrip de panelNumero
                    isInside = true;  // pone a true cuando se mantiene dentro del objeto
                    
                }
            }         
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.tag == "hand"){
            isInside = false;  //se pone a false cuando sale del collider

        }
    } 

}

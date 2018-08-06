using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teclaOpcion : MonoBehaviour {

    public Sprite normal;
    public Sprite onClick;
    public Sprite click;
    private bool isInside = false;
    public GameObject opcionFinal;

    public GameObject tecla;
    public GameObject opcion;

    private void Start()
    {
        tecla.GetComponent<SpriteRenderer>().sprite = normal;
    }



    private void OnTriggerEnter(Collider other)
    {
        tecla.GetComponent<SpriteRenderer>().sprite = onClick;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!opcionFinal.GetComponent<opcionFinal>().isClick)
        {
            if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Three)) // comprueba si se mantiene dentro y clica la A 
            {
                if (!isInside)
                {

                    tecla.GetComponent<SpriteRenderer>().sprite = click;

                    if (tecla.name == "Abandon" || tecla.name == "Abandonar")
                    {
                        opcion.GetComponent<opcionFinal>().opcionAbandonar();
                    }
                    if (tecla.name == "Forgive" || tecla.name == "Perdonar")
                    {
                        opcion.GetComponent<opcionFinal>().opcionPerdonar();
                    }

                    isInside = true;

                }
            }
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (!opcionFinal.GetComponent<opcionFinal>().isClick)
        {
            if (other.tag == "hand")
            {
                if (!isInside)
                {
                    tecla.GetComponent<SpriteRenderer>().sprite = normal;
                }

            }
        }
    }

    




}

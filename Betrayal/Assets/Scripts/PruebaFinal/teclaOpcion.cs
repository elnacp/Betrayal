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
    public bool cliqui;

    private void Start()
    {
        tecla.GetComponent<SpriteRenderer>().sprite = normal;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (variablesGlobals.prova6)
        {
            if (!opcionFinal.GetComponent<opcionFinal>().isClick)
            {
                tecla.GetComponent<SpriteRenderer>().sprite = onClick;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(variablesGlobals.prova6)
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
                            cliqui = true;
                        }
                        if (tecla.name == "Forgive" || tecla.name == "Perdonar")
                        {
                            opcion.GetComponent<opcionFinal>().opcionPerdonar();
                            cliqui = true;
                        }

                        isInside = true;

                    }
                }
            }
        }
        
        
    }


    private void OnTriggerExit(Collider other)
    {
        if(variablesGlobals.prova6)
        {
            if (!opcionFinal.GetComponent<opcionFinal>().isClick)
            {
                if (other.tag == "hand")
                {
                    if (!isInside)
                    {
                        if (!cliqui)
                        {
                            tecla.GetComponent<SpriteRenderer>().sprite = normal;
                        }
                        if (cliqui)
                        {
                            tecla.GetComponent<SpriteRenderer>().sprite = click;
                        }
                    }

                }
            }
        }
        
        
    }

    




}

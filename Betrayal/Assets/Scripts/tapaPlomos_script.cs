using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapaPlomos_script : MonoBehaviour {
    private Animator anim;
    private bool isOpen;


    public GameObject abrirA;
    public GameObject abrirX;
    public GameObject cerrarB;
    public GameObject cerrarY;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        isOpen = false;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}


    void OnTriggerStay(Collider col)
    {
        if(variablesGlobals.prova2)
        {
            if (col.name == "LeftHandAnchor")
            {
                //ABRE LA TAPA DE LA CAJA DE PLOMOS
                if (OVRInput.Get(OVRInput.Button.Three))
                {
                    //Si no se ha entrado en esta opcion se activa la animacion
                    if (!isOpen)
                    {
                        Debug.Log("OPEEEEEN");
                        anim.SetBool("open", true);
                        isOpen = true;
                    }

                }

                //CIERRA LA TAPA DE LA CAJA DE PLOMOS
                if (OVRInput.Get(OVRInput.Button.Four))
                {
                    //Si no se ha entrado en esta opcion se activa la animacion
                    if (isOpen)
                    {
                        anim.SetBool("open", false);
                        isOpen = false;
                    }

                }
            }

            if (col.name == "RightHandAnchor")
            {
                //ABRE LA TAPA DE LA CAJA DE PLOMOS
                if (OVRInput.Get(OVRInput.Button.One))
                {
                    //Si no se ha entrado en esta opcion se activa la animacion
                    if (!isOpen)
                    {

                        anim.SetBool("open", true);
                        isOpen = true;
                    }

                }

                //CIERRA LA TAPA DE LA CAJA DE PLOMOS
                if (OVRInput.Get(OVRInput.Button.Two))
                {
                    //Si no se ha entrado en esta opcion se activa la animacion
                    if (isOpen)
                    {
                        anim.SetBool("open", false);
                        isOpen = false;
                    }

                }
            }
        }
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (variablesGlobals.prova2)
        {
            if (other.name == "RightHandAnchor")
            {
                if (isOpen)
                {
                    cerrarB.SetActive(true);
                    StartCoroutine("WaitForSec");
                }
                else
                {
                    abrirA.SetActive(true);
                    StartCoroutine("WaitForSec");
                }

            }

            if (other.name == "LeftHandAnchor")
            {
                if (isOpen)
                {
                    cerrarY.SetActive(true);
                    StartCoroutine("WaitForSec");
                }
                else
                {
                    abrirX.SetActive(true);

                }
            }
        }
        
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
    }

    private void OnTriggerExit(Collider other)
    {
        abrirX.SetActive(false);
        abrirA.SetActive(false);
        cerrarB.SetActive(false);
        cerrarY.SetActive(false);
    }


}

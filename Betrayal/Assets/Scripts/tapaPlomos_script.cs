using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapaPlomos_script : MonoBehaviour {
    public Animator anim;
    private bool isOpen;

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
        //ABRE LA TAPA DE LA CAJA DE PLOMOS
        if (OVRInput.Get(OVRInput.Button.One))
        {
            //Si no se ha entrado en esta opcion se activa la animacion
            if(!isOpen)
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

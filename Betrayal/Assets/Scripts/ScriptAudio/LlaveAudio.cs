﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveAudio : MonoBehaviour {

    private bool isEnter;
    public GameObject alex;
    public GameObject mensaje;
    public bool destruir = false;


    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "hand")
        {
            if (!isEnter)
            {
                if(variablesGlobals.lang.Equals("español"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(36);
                    mensaje.GetComponent<MensajePrueba>().BuidarText();
                    isEnter = true;
                }
                if (variablesGlobals.lang.Equals("english"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(50);
                    mensaje.GetComponent<MensajePrueba>().BuidarText();
                    isEnter = true;
                }

            }
        }

        if( other.name == "TuboComunicació")
        {
            Debug.Log("ENTRO");
            
            destruir = true;
        }

    }

    private void Update()
    {
        if( destruir == true)
        {
            Destroy(gameObject);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroAudio : MonoBehaviour {

    public GameObject alex;
    public bool isInside = false;


    public void OnTriggerEnter(Collider other)
    {
        if(variablesGlobals.prova42)
        {
            if (!isInside)
            {
                if (variablesGlobals.lang.Equals("español"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(45);
                }
                if (variablesGlobals.lang.Equals("english"))
                {
                    alex.GetComponent<AudioAlex>().ActivateAudio(55);
                }
                isInside = true;

            }
        }
        
    }




}

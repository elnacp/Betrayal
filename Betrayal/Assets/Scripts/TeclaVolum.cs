using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclaVolum : MonoBehaviour {

    public GameObject tecla; // tecla
    public bool isInside = false; //

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "hand")  // mira si el colisionador es una mano
        {
            if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Three)) // comprueba si se mantiene dentro y clica la A 
            {
                if (!isInside)
                {

                    tecla.GetComponent<VolumStory>().ChangeMute(gameObject);
                    isInside = true;

                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "hand")
        {
            isInside = false;  //se pone a false cuando sale del collider
            
        }
    }
}

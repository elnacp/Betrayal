using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour {

    public GameObject luz;
    private bool isOn;


    void Update()
    {
        if (isOn)
        {
            luz.SetActive(true);
        }
        if (!isOn)
        {
            luz.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if( other.tag == "hand")
        {
            
            
            Debug.Log("linterna  . entro en el bucle");
            if (OVRInput.Get(OVRInput.Button.One))
            {
                if (!isOn)
                {
                    Debug.Log("ON");
                    isOn = true;
                }
            }

            if (OVRInput.Get(OVRInput.Button.Two))
            {
                if (isOn)
                {
                    Debug.Log("OFF");
                    isOn = false;
                }
            }
            
            
            

                

            
            

        }


    }



}

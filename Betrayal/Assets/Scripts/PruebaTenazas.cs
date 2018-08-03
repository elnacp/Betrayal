using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaTenazas : MonoBehaviour {

    public GameObject alicates;
    public GameObject oso;


    private bool destruir = false;

    private void OnTriggerEnter(Collider other)
    {
        if (variablesGlobals.prova43)
        {
            if (other.name == "Cuchillo")
            {
                destruir = true;
                alicates.SetActive(true);
            }
        }
        
    }

    private void Update()
    {
        if( destruir)
        {
            Destroy(oso);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaTenazas : MonoBehaviour {

    public GameObject alicates;
    public GameObject oso;


    private bool destruir = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entro");
        Debug.Log(other.name);
        if (variablesGlobals.prova43)
        {
            if (other.name == "Cuchillo")
            {
                destruir = true;
                Debug.Log("destruyo");
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

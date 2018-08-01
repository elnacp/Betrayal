using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConoScript : MonoBehaviour {

    public GameObject cono;

	
    public void eliminarCono()
    {
        if (variablesGlobals.prova42)
        {
            Destroy(cono);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acumuladorPuzle : MonoBehaviour {

    public  int acomulador = 0;
    public bool entro = false;

	// Use this for initialization
	void Start () {
        acomulador = 0;
	}

    private void Update()
    {

        if (entro)
        {
            Debug.Log(acomulador);
            entro = false;
        }


        // SI EL ACOMULADOR llega a 24 significa que el puzle ya esta echo.


    }


}

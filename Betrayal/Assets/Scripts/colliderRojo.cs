using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderRojo : MonoBehaviour {

    public GameObject CubeRed;
    public GameObject PlomRojo;
    private bool destruir = false;
    public GameObject plomi;


    private void Update()
    {
        if (destruir == true)
        {
            Destroy(plomi);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "plomi_red")
        {

            CubeRed.SetActive(true);
            PlomRojo.SetActive(true);
            //other.gameObject.SetActive(false);
            destruir = true;
        }
    }
}

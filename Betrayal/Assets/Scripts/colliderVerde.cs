using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderVerde : MonoBehaviour {

    public GameObject CubeGreen;
    public GameObject PlomVerd;
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
        if (other.name == "plomi_green")
        {

            CubeGreen.SetActive(true);
            PlomVerd.SetActive(true);
            //other.gameObject.SetActive(false);
            destruir = true;
        }
    }

}

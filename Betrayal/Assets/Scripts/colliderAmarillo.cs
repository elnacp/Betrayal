using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderAmarillo : MonoBehaviour {

    public GameObject CubeYellow;
    public GameObject PlomAmarillo;
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
        if (other.name == "plomi_yellow")
        {

            CubeYellow.SetActive(true);
            PlomAmarillo.SetActive(true);
            //other.gameObject.SetActive(false);
            destruir = true;
        }
    }
}

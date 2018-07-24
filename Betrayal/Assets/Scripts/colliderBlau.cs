using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderBlau : MonoBehaviour {

    public GameObject CubeBlau;
    public GameObject PlomBlau;
    private bool destruir = false;
    public GameObject plomi;
    public GameObject acomulador;  


    private void Update()
    {
        if( destruir == true)
        {
            Destroy(plomi);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.name == "plomi_blue")
        {
            
            CubeBlau.SetActive(true);
            PlomBlau.SetActive(true);
            //other.gameObject.SetActive(false);
            destruir = true;
            acomulador.GetComponent<AcomuladorPlomillos>().acomulaPlomi();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caixaPloms : MonoBehaviour {

    public GameObject CubeBlau;
    public GameObject CubeVerd;
    public GameObject CubeVermell;
    public GameObject CubeGroc;

    public GameObject PlomBlau;
    public GameObject PlomVerd;
    public GameObject PlomVermell;
    public GameObject PlomGroc;


    public GameObject Blau;
    public GameObject Verd;
    public GameObject Vermell;
    public GameObject Groc;



    private void OnTriggerEnter(Collider other)
    {
        
        if( other.gameObject.name == "PlomB" && gameObject.name == "Blue")
        {
            colocarPlom(CubeBlau, PlomBlau, other.gameObject);
        }

        if (other.name == "PlomG" && gameObject.name == "Green")
        {
            colocarPlom(CubeVerd, PlomVerd, other.gameObject);
        }

        if (other.name == "PlomR" && gameObject.name == "Red")
        {
            colocarPlom(CubeVermell, PlomVermell, other.gameObject);
        }

        if (other.name == "PlomY" && gameObject.name == "Yellow")
        {
            colocarPlom(CubeGroc, PlomGroc, other.gameObject);
        }


    }

    void colocarPlom( GameObject cube, GameObject plom, GameObject plomPosat)
    {
        cube.SetActive(true);
        plom.SetActive(true);
        plomPosat.SetActive(false);
    }

    


}

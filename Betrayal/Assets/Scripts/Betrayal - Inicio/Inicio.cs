using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour {

    public GameObject creado;
    public GameObject create;
    public GameObject clica;
    public GameObject click;



    // Use this for initialization
    void Start () {

        actualitza();
    
    }
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.Get(OVRInput.Button.One)){
            SceneManager.LoadScene(2);
        }


	}

    private void actualitza()
    {
        if (variablesGlobals.lang.Equals("español"))
        {
            creado.SetActive(true);
            clica.SetActive(true);
            create.SetActive(false);
            click.SetActive(false);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            creado.SetActive(false);
            clica.SetActive(false);
            create.SetActive(true);
            click.SetActive(true);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class ChangeScenesMenu : MonoBehaviour {

    public GameObject boton;
    public Text texto;



    private void Start()
    {
        texto.text = "";
    }





    private void OnTriggerEnter(Collider other)
    {
        if( other.name == "RightHandAnchor")
        {
            texto.text = "Clica A para continuar"; 
        }

        if (other.name == "LeftHandAnchor")
        {
            texto.text = "Clica X para continuar";
        }



    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "hand")
        {
            if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Three)) // comprueba si se mantiene dentro y clica la A 
            {
                if(boton.name == "Jugar")
                {
                    ChangeToScene(1);
                }
                if(boton.name == "Historia")
                {
                    ChangeToScene(3);
                }
                if(boton.name == "Ajustes")
                {
                    ChangeToScene(2);
                }
                if(boton.name == "Salir")
                {
                    Application.Quit();
                }


            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if( other.tag == "hand")
        {
            
           texto.text = "";
            
        }
    }



    public void ChangeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }







}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalJuego : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hand")
        {
            Debug.Log("Salgo");
            //FINAL DEL JUEGO SE VA A LA PANTALLA DE MENÚ
            SceneManager.LoadScene(0);
        }
    }
}

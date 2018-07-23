using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajesTubo : MonoBehaviour {

    public GameObject m_english;  //mensaje : "Communication tube"
    public GameObject m_español;  //mensaje : "Tubo de comunicacion"
    public GameObject flecha;



    public void MostrarMensaje()
    {
        if (variablesGlobals.lang.Equals("español"))
        {
            m_español.SetActive(true);
            flecha.SetActive(true);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            m_english.SetActive(true);
            flecha.SetActive(true);
        }

    }



}

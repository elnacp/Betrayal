using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesGlobals : MonoBehaviour {

    static public string lang = "español";
    static public bool english = false;
    static public bool spanish = true;
    static public bool prova1 = false;
    static public bool prova2 = false;
    static public bool prova3 = false;
    static public bool prova41 = false;
    static public bool prova42 = false;
    static public bool prova43 = false;
    static public bool prova5 = false;
    static public bool opcion = false;
    static public float time = 0;
    static public bool playing = true;
    static public bool finalPartida = false;

    static public bool entroEscena = false;
    
    //retorna que lengua estas usando
	static public string getLang()
    {
        return lang;
    }
    //sustituye la lengua del juego
    static public void setLang(string change)
    {
        lang = change;
    }

    
}

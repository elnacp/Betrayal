﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesGlobals : MonoBehaviour {

    static public string lang = "english";
    static public bool english = false;
    static public bool spanish = true;
    
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

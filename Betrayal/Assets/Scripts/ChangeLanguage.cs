using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour {

    public Sprite E_normal;
    public Sprite E_onClick;
    public Sprite E_click;

    public Sprite S_normal;
    public Sprite S_onClick;
    public Sprite S_click;

    public GameObject english;
    public GameObject spanish;

    private string lang = "";

    private void Start()
    {
        lang = variablesGlobals.lang;
        if(lang.Equals("español"))
        {
            spanish.GetComponent<SpriteRenderer>().sprite = S_click;
            english.GetComponent<SpriteRenderer>().sprite = E_normal;

        }else
        {
            english.GetComponent<SpriteRenderer>().sprite = E_click;
            spanish.GetComponent<SpriteRenderer>().sprite = S_normal;
        }

    }

    public void ChangeKey(GameObject game)
    {
        if( game.name == "Español")
        {
            spanish.GetComponent<SpriteRenderer>().sprite = S_click;
            english.GetComponent<SpriteRenderer>().sprite = E_normal;
            variablesGlobals.setLang("español");
        }else
        {
            english.GetComponent<SpriteRenderer>().sprite = E_click;
            spanish.GetComponent<SpriteRenderer>().sprite = S_normal;
            variablesGlobals.setLang("english");
        }

    }

    public void DuringEnter( GameObject obj)
    {
        if(obj.name == "Español")
        {
            spanish.GetComponent<SpriteRenderer>().sprite = S_onClick;
        }else
        {
            english.GetComponent<SpriteRenderer>().sprite = E_onClick;
        }
    }

    public void DuringExit( GameObject obj)
    {
        if (obj.name == "Español")
        {
           if(variablesGlobals.lang.Equals("español"))
            {
                spanish.GetComponent<SpriteRenderer>().sprite = S_click;
            }else
            {
                spanish.GetComponent<SpriteRenderer>().sprite = S_normal;
            }
        }
        
        if(obj.name == "English")
            if (variablesGlobals.lang.Equals("english"))
            {
                english.GetComponent<SpriteRenderer>().sprite = E_click;
            }
            else
            {
               english.GetComponent<SpriteRenderer>().sprite = E_normal;
            }
        }
    }


    






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelNumeros : MonoBehaviour {

    public static string codiCorrecte="2573";
    public static string playerCode = "";
    public static int contador = 0;  // conta la quantitat de digits que shan clicat 
    public Sprite[] sp;
    public static int clica = 0;
    public static int incorrecte = 1;
    private int correcte = 1;
    private int num = 0;
    

    //public string letra;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(playerCode);
        //GetComponent<SpriteRenderer>().sprite = sp[2];

        if( correcte == 1)
        {
            num++;
            correcte = 0;
        }



        if ( incorrecte == 1)
        {
                playerCode = "";
                num = 0;    
            
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<SpriteRenderer>().sprite = sp[1];
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<SpriteRenderer>().sprite = sp[0];
    }

    private void OnTriggerStay(Collider other)
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            if( num == 0 ) {
                if (other.tag[0] == codiCorrecte[0])
                {
                    GetComponent<SpriteRenderer>().sprite = sp[2];
                    correcte = 1;
                }else
                {
                    GetComponent<SpriteRenderer>().sprite = sp[3];
                    incorrecte = 1;
                }
            }
            if( num == 1)
            {
                if(other.tag[0] == codiCorrecte[1])
                {
                    GetComponent<SpriteRenderer>().sprite = sp[2];
                    correcte = 1;
                }else
                {
                    GetComponent<SpriteRenderer>().sprite = sp[3];
                    incorrecte = 1;
                }
            }
            if( num == 2)
            {
                if (other.tag[0] == codiCorrecte[2])
                {
                    GetComponent<SpriteRenderer>().sprite = sp[2];
                    correcte = 1;
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = sp[3];
                    incorrecte = 1;
                }
            }
            if( num == 3)
            {
                if (other.tag[0] == codiCorrecte[3])
                {
                    GetComponent<SpriteRenderer>().sprite = sp[2];
                    correcte = 1;
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = sp[3];
                    incorrecte = 1;
                }
            }

        }
    }




    /*private void OnMouseUp()
    {
        if( clicat == 0)
        {
            //Debug.Log(contador);
            clicat = 1;
            playerCode += gameObject.name;
            contador += 1;
        }
       // Debug.Log("Contador:" +contador);
        if (contador == 1)
        {
            if (playerCode[0] == codiCorrecte[0])
            {
                //Debug.Log("entro 1");
                
                incorrecte = 0;
            }
        }
        else
        {
            if (contador == 2 && clicat != 1)
            {
                if (playerCode[1] == codiCorrecte[1])
                {
                    //Debug.Log("entro 2");
                    GetComponent<SpriteRenderer>().sprite = sp[2];
                    incorrecte = 0;
                }

            }
            else
            {
                if (contador == 3 && clicat != 1)
                {
                    if (playerCode[2] == codiCorrecte[2])
                    {
                        //Debug.Log("entro 3");
                        GetComponent<SpriteRenderer>().sprite = sp[2];
                        incorrecte = 0;
                    }
                    else
                    {
                        if (contador == 4 & clicat != 1)
                        {
                            if (playerCode == codiCorrecte)
                            {
                                //Debug.Log("entro 4");
                               // GetComponent<TextMesh>().text = "Correcte";
                            }
                        }
                    }
                }

            }

        }



        //GetComponent<SpriteRenderer>().sprite = sp[2];
        //StartCoroutine(esperarCanvi());
        //clica = 1;
    }

    public void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = sp[1];
    }

    private void OnMouseExit()
    {
       
        GetComponent<SpriteRenderer>().sprite = sp[0];
        
        
    }

    IEnumerator esperarCanvi()
    {
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().sprite = sp[0];
        clica = 0;
    }*/

}

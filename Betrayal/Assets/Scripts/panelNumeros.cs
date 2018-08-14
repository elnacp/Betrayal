using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


//CONTROLA EL KEYPAD
public class panelNumeros : MonoBehaviour {
    public int[] codigo;
    public GameObject brooke;


    public GameObject numero1;
    public GameObject numero2;
    public GameObject numero3;
    public GameObject numero4;
    public GameObject numero5;
    public GameObject numero6;
    public GameObject numero7;
    public GameObject numero8;
    public GameObject numero9;

    public GameObject audioPanel;
    

    public bool codiInsertat = false;
    public bool codiIncorrecte = false;

    public TextMesh texto;
    public GameObject aceptar;
    public GameObject eliminar;

    private string textoEspera;
    private string textoError;
    private string textoAcertado;

    List<int> cod = new List<int>();
    int index = 0;

    // Inicialitza el texto
    void Start()
    {

        if(variablesGlobals.lang.Equals("español"))
        {
            textoEspera = "INSERTA CODIGO";
            textoError = "CODIGO INCORRECTO";
            textoAcertado = "CODIGO CORRECTO";
        }

        if (variablesGlobals.lang.Equals("english"))
        {
            textoEspera = "INSERT CODE";
            textoError = "INCORRECT CODE";
            textoAcertado = "CORRECT CODE";
        }


        texto.GetComponent<TextMesh>().text = textoEspera;
        texto.fontSize = 16;

    }

    //recibe del script de tecla 
    public void rebreCodi(GameObject tecla)
    {
        if (tecla == numero1)
        {
            aumentarCod(1);
        }
        if (tecla == numero2)
        {
            aumentarCod(2);
        }
        if (tecla == numero3)
        {
            aumentarCod(3);
        }
        if (tecla == numero4)
        {
            aumentarCod(4);
        }
        if (tecla == numero5)
        {
            aumentarCod(5);
        }
        if (tecla == numero6)
        {
            aumentarCod(6);
        }
        if (tecla == numero7)
        {
            aumentarCod(7);
        }
        if (tecla == numero8)
        {
            aumentarCod(8);
        }
        if (tecla == numero9)
        {
            aumentarCod(9);
        }

        if( tecla == eliminar)
        {
            eliminarCodi();
        }

        if( tecla == aceptar)
        {
            autentificarCodi();
        }


    }

    void autentificarCodi()
    {
        if (!variablesGlobals.finalPartida)
        {
            if (index == codigo.Length)
            {

                bool correct = true;

                for (int i = 0; i < codigo.Length; i++)
                {
                    if (cod[i] != codigo[i])
                    {

                        correct = false;
                        break;
                    }
                }

                if (correct == true)
                {
                    texto.GetComponent<TextMesh>().text = textoAcertado;
                    texto.fontSize = 16;
                    audioPanel.GetComponent<PanelAudio>().CorrectCode();
                    codiInsertat = true;
                    pruebaFinalizada();


                }
                else
                {
                    texto.GetComponent<TextMesh>().text = textoError;
                    texto.fontSize = 16;
                    borrar();
                    audioPanel.GetComponent<PanelAudio>().IncorrectCode();
                    darPista();
                }



            }
            else
            {
                texto.GetComponent<TextMesh>().text = textoError;
                texto.fontSize = 16;
                borrar();
                audioPanel.GetComponent<PanelAudio>().IncorrectCode();
                codiIncorrecte = true;
                darPista();
            }
        }
        
        

    }

    void borrar()  
    {
        cod.Clear();
        index = 0;
    }

    void eliminarCodi()
    {
        if (!variablesGlobals.finalPartida)
        {
            borrar();
            texto.GetComponent<TextMesh>().text = textoEspera;
            texto.fontSize = 16;
        }
        
    }

    public void aumentarCod( int num)
    {
        cod.Add(num);  // Incluimos el numero en la lista para despues poder comprobar el codigo
        index++;  // Aumentamos el indice para indicar que vamos a poner un * más por pantalla

        texto.GetComponent<TextMesh>().text = "";  // inicializamos el mensaje de texto
        texto.fontSize = 16;

        for ( int i = 0; i < index; i++)
        {
            texto.GetComponent<TextMesh>().text += "*";  //segun los elementos que vayan entrando ira mostrando *
            texto.fontSize = 45;
            audioPanel.GetComponent<PanelAudio>().ClickCode();
        }
    }


    //EN EL CASO DE ERROR DAMOS PISTA
    private void darPista()
    {
        if(variablesGlobals.lang.Equals("español"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(20);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(67);
        }


    }


    private void pruebaFinalizada()
    {
        if (variablesGlobals.lang.Equals("español"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(21);
        }
        if (variablesGlobals.lang.Equals("english"))
        {
            brooke.GetComponent<AudioBrooke>().ActivateAudio(68);
        }


    }



}




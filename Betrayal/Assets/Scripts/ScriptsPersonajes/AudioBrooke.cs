using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioBrooke : MonoBehaviour
{
    public GameObject mensaje;
    public GameObject alex;
    public GameObject mensajeTubo;
    public GameObject jane;
    public GameObject panel;
    public GameObject instrucciones;
    public GameObject audioReloj;

    public GameObject mesaPuzle;
    public GameObject colosionadores;
    public GameObject pieza1;
    public GameObject pieza2;
    public GameObject puzleNointeractivo;

    

    AudioSource brooke;

    //AUDIOS EN ESPAÑOL
    public AudioClip audio15;
    public AudioClip audio16;
    public AudioClip audio17;
    public AudioClip audio18;
    public AudioClip audio19;
    public AudioClip audio20;
    public AudioClip audio21;
    public AudioClip audio22;
    public AudioClip audio23;
    public AudioClip audio24;
    public AudioClip audio25;
    public AudioClip audio26;
    public AudioClip audio27;
    public AudioClip audio28;
    public AudioClip audio29;
    public AudioClip audio30;
    public AudioClip audio31;
    public AudioClip audio32;
    
    //AUDIOS EN INGLES
    public AudioClip audio61;
    public AudioClip audio62;
    public AudioClip audio63;
    public AudioClip audio64;
    public AudioClip audio65;
    public AudioClip audio66;
    public AudioClip audio67;
    public AudioClip audio68;
    public AudioClip audio69;
    public AudioClip audio70;
    public AudioClip audio71;
    public AudioClip audio72;
    public AudioClip audio73;
    public AudioClip audio74;
    public AudioClip audio75;
    public AudioClip audio76;
    public AudioClip audio77;
    public AudioClip audio78;

    private string lang;
    private bool español = false;
    private bool english = false;

    private int personatge;
    private int numeroAudio;



    



    // Use this for initialization
    void Start () {
        lang = variablesGlobals.lang;
        brooke = GetComponent<AudioSource>();
    }



    private void PedirActivar()
    {
        switch (personatge)
        {
            case 1: // ALEX
                alex.GetComponent<AudioAlex>().ActivateAudio(numeroAudio);
                break;
            case 2:
                ActivateAudio(numeroAudio);
                break;
            case 3: //JANE
                jane.GetComponent<AudioJane>().ActivateAudio(numeroAudio);
                break;
        }
    }





    public void ActivateAudio(int num)
    {
        switch (num)
        {
            //DIALOGO EN ESPAÑOL
            case 15:
                brooke.clip = audio15;
                brooke.Play();
                numeroAudio = 34;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 16:
                brooke.clip = audio16;
                brooke.Play();
                numeroAudio = 35;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 17:
                brooke.clip = audio17;
                brooke.Play();
                variablesGlobals.prova1 = true;
                mensaje.GetComponent<MensajePrueba>().TitleTest(1, lang);
                mensajeTubo.GetComponent<MensajesTubo>().MostrarMensaje();
                break;
            case 18:
                brooke.clip = audio18;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(2, lang);
                mensajeTubo.GetComponent<MensajesTubo>().QuitarMensaje();
                variablesGlobals.prova1 = false;
                variablesGlobals.prova2 = true;
                break;
            case 19:
                brooke.clip = audio19;
                brooke.Play();
                panel.SetActive(true);
                break;
            case 20:
                brooke.clip = audio20;
                brooke.Play();
                break;
            case 21:
                brooke.clip = audio21;
                brooke.Play();
                numeroAudio = 40;
                personatge = 1;
                mensaje.GetComponent<MensajePrueba>().TitleTest(4, lang);
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 26:
                brooke.clip = audio26;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(41, lang);
                variablesGlobals.prova41 = true;
                break;
            case 27:
                brooke.clip = audio27;
                brooke.Play();
                break;
            case 28:
                brooke.clip = audio28;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(42, lang);
                break;
            case 29:
                brooke.clip = audio29;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(43, lang);
                variablesGlobals.prova42 = false;
                variablesGlobals.prova43 = true;
                numeroAudio = 30;
                personatge = 2;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 30:
                brooke.clip = audio30;
                brooke.Play();
                instrucciones.SetActive(true);
                break;
            case 31:
                brooke.clip = audio31;
                brooke.Play();
                apareixPuzle();
                mensaje.GetComponent<MensajePrueba>().TitleTest(5, lang);
                break;
            case 22:
                jane.GetComponent<AudioJane>().DesactivarTele();
                brooke.clip = audio22;
                brooke.Play();
                numeroAudio = 43;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 23:
                brooke.clip = audio23;
                brooke.Play();
                numeroAudio = 44;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 24:
                brooke.clip = audio24;
                brooke.Play();
                Invoke("activarFinal", brooke.clip.length);
                break;
            case 25:
                brooke.clip = audio25;
                brooke.Play();
                //SE APAGAN LAS LUCES DE LA HABITACION
                Invoke("FinalPartida", brooke.clip.length);
                break;
            case 32:
                brooke.clip = audio32;
                brooke.Play();
                numeroAudio = 6;
                personatge = 3;
                Invoke("PedirActivar", brooke.clip.length);
                break;





            //DIALOGO EN INGLES
            case 62:
                brooke.clip = audio62;
                brooke.Play();
                numeroAudio = 48;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 63:
                brooke.clip = audio63;
                brooke.Play();
                numeroAudio = 49;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 64:
                brooke.clip = audio64;
                brooke.Play();
                variablesGlobals.prova1 = true;
                mensaje.GetComponent<MensajePrueba>().TitleTest(1, lang);
                mensajeTubo.GetComponent<MensajesTubo>().MostrarMensaje();
                break;
            case 65:
                brooke.clip = audio65;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(2, lang);
                mensajeTubo.GetComponent<MensajesTubo>().QuitarMensaje();
                variablesGlobals.prova1 = false;
                variablesGlobals.prova2 = true;
                break;
            case 66:
                brooke.clip = audio66;
                brooke.Play();
                panel.SetActive(true);
                break;
            case 67:
                brooke.clip = audio67;
                brooke.Play();
                break;
            case 68:
                brooke.clip = audio68;
                brooke.Play();
                numeroAudio = 54;
                personatge = 1;
                mensaje.GetComponent<MensajePrueba>().TitleTest(4, lang);
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 69:
                brooke.clip = audio69;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(41, lang);
                variablesGlobals.prova41 = true;
                break;
            case 70:
                brooke.clip = audio70;
                brooke.Play();
                break;
            case 71:
                brooke.clip = audio71;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(42, lang);
                break;
            case 72:
                brooke.clip = audio72;
                brooke.Play();
                mensaje.GetComponent<MensajePrueba>().TitleTest(43, lang);
                variablesGlobals.prova42 = false;
                variablesGlobals.prova43 = true;
                numeroAudio = 73;
                personatge = 2;
                Invoke("PedirActivar", brooke.clip.length);
                break;
            case 73:
                brooke.clip = audio73;
                brooke.Play();
                instrucciones.SetActive(true);
                break;
            case 74:
                brooke.clip = audio74;
                brooke.Play();
                apareixPuzle();
                mensaje.GetComponent<MensajePrueba>().TitleTest(5, lang);
                break;
            case 75:
                jane.GetComponent<AudioJane>().DesactivarTele();
                brooke.clip = audio75;
                brooke.Play();
                numeroAudio = 59;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length); 
                break;
            case 76:
                brooke.clip = audio76;
                brooke.Play();
                numeroAudio = 60;
                personatge = 1;
                Invoke("PedirActivar", brooke.clip.length);

                break;
            case 77:
                brooke.clip = audio77;
                brooke.Play();
                Invoke("activarFinal", brooke.clip.length);
                
                break;
            case 61:
                brooke.clip = audio61;
                brooke.Play();
                //SE APAGAN LAS LUCES DE LA HABITACION
                Invoke("FinalPartida", brooke.clip.length);
                break;
            case 78:
                brooke.clip = audio78;
                brooke.Play();
                numeroAudio = 13;
                personatge = 3;
                Invoke("PedirActivar", brooke.clip.length);
                break;

        }

        
    }

    private void activarFinal()
    {
        variablesGlobals.prova6 = true;
        variablesGlobals.time = 60;
        variablesGlobals.playing = true;
        audioReloj.GetComponent<AudioReloj>().ActivarReloj();
    }
        
    private void apareixPuzle()
    {
        mesaPuzle.SetActive(true);
        colosionadores.SetActive(true);
        pieza1.SetActive(true);
        pieza2.SetActive(true);
        puzleNointeractivo.SetActive(true);
    }

    public void desapareixPuzle()
    {
        colosionadores.SetActive(false);
        puzleNointeractivo.SetActive(false);
    }

    public void Buidar()
    {
        brooke.clip = null;
    }

    private void FinalPartida()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioJane : MonoBehaviour
{

    public GameObject brooke;
    public GameObject alex;
    public GameObject pantallaTele;
    public GameObject panellFinal;
    public GameObject forgive;
    public GameObject perdonar;
    public GameObject abandon;
    public GameObject abandonar;
    public GameObject rellotge;
    public GameObject spotlight;

    public Light d1;
    public Light d2;
    public Light d3;
    public Light d4;

    public AudioSource jane;

    //AUDIO ESPAÑOL
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public AudioClip audio5;
    public AudioClip audio6;
    public AudioClip audio7;


    //AUDIO INGLES
    public AudioClip audio8;
    public AudioClip audio9;
    public AudioClip audio10;
    public AudioClip audio11;
    public AudioClip audio12;
    public AudioClip audio13;
    public AudioClip audio14;

    private string lang;
    private int personatge;
    private int numeroAudio;

    public GameObject mensaje;

    // Use this for initialization
    void Start()
    {
        jane.GetComponent<AudioSource>();
        lang = variablesGlobals.lang;

    }

    private void PedirActivar()
    {
        switch (personatge)
        {
            case 1: // ALEX
                alex.GetComponent<AudioAlex>().ActivateAudio(numeroAudio);
                break;
            case 2: // BROOKE
                brooke.GetComponent<AudioBrooke>().ActivateAudio(numeroAudio);
                break;
            case 3:
                ActivateAudio(numeroAudio);
                break;
        }
    }


    private void PedirDesactivar()
    {
        pantallaTele.GetComponent<TelevisorAudio>().DesactivarTelevisor();
        pantallaTele.SetActive(false);

        if (lang.Equals("español")){
            numeroAudio = 19;   
        }
        if (lang.Equals("english"))
        {
            numeroAudio = 66;
        }
        Debug.Log(numeroAudio);
        personatge = 2;
        mensaje.GetComponent<MensajePrueba>().TitleTest(3, lang);
        Invoke("PedirActivar", 3);

        
    }

    public void DesactivarTele()
    {
        pantallaTele.GetComponent<TelevisorAudio>().DesactivarTelevisor();
        pantallaTele.SetActive(false);
    }

    public void ActivarTele()
    {
        pantallaTele.SetActive(true);
        pantallaTele.GetComponent<TelevisorAudio>().ActivarTelevisor();
    }


    public void ActivateAudio(int num)
    {
        switch (num)
        {

            //AUDIO ESPAÑOL
            case 1:
                ActivarTele();
                jane.clip = audio1;
                jane.Play();
                numeroAudio = 39;
                personatge = 1;
                Invoke("PedirActivar", jane.clip.length + 1);
                break;
            case 2:
                jane.clip = audio2;
                jane.Play();
                variablesGlobals.playing = true;
                variablesGlobals.prova3 = true;
                Invoke("PedirDesactivar", jane.clip.length + 2);               
                break;
            case 3:
                ActivarTele();
                jane.clip = audio3;
                jane.Play();
                numeroAudio = 4;
                personatge = 3;
                variablesGlobals.playing = false;
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 4:
                jane.clip = audio4;
                jane.Play();
                //SE ACTIVA EL CONTADOR A 2 MIN (FALTA EL RELOJ Y EL AUDIO ) 
                numeroAudio = 22;
                personatge = 2;
                panellFinal.SetActive(true);
                perdonar.SetActive(true);
                abandonar.SetActive(true);
                spotlight.SetActive(true);
                bajarLuz();    
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 5:
                jane.clip = audio5;
                jane.Play();
                numeroAudio = 25;
                personatge = 2;
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 6:
                //SE ABREN LAS PUERTAS
                jane.clip = audio6;
                jane.Play();              
                break;
            case 7:
                ActivarTele();
                jane.clip = audio7;
                jane.Play();
                desactivarRellotge();
                d1.color = Color.red;
                d2.color = Color.red;
                d3.color = Color.red;
                d4.color = Color.red;
                Invoke("DesactivarTele", jane.clip.length);
                break;
       


            case 8:
                ActivarTele();
                jane.clip = audio8;
                jane.Play();
                numeroAudio = 53;
                personatge = 1;
                Invoke("PedirActivar", jane.clip.length + 1);
                break;
            case 9:
                jane.clip = audio9;
                jane.Play();
                variablesGlobals.playing = true;
                variablesGlobals.prova3 = true;
                Invoke("PedirDesactivar", jane.clip.length +2);
                break;
            case 10:
                ActivarTele();
                jane.clip = audio10;
                jane.Play();                
                numeroAudio = 11;
                personatge = 3;
                variablesGlobals.playing = false;
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 11:
                jane.clip = audio11;
                jane.Play();
                panellFinal.SetActive(true);
                forgive.SetActive(true);
                abandon.SetActive(true);
                spotlight.SetActive(true);
                bajarLuz();    
                numeroAudio = 75;
                personatge = 2;
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 12:
                jane.clip = audio12;
                jane.Play();
                numeroAudio = 61;
                personatge = 2;
                Invoke("PedirActivar", jane.clip.length);
                break;
            case 13:
                //SE ABREN LAS PUERTAS
                jane.clip = audio13;
                jane.Play();
                break;
            case 14:
                ActivarTele();
                jane.clip = audio14;
                jane.Play();
                desactivarRellotge();
                d1.color = Color.red;
                d2.color = Color.red;
                d3.color = Color.red;
                d4.color = Color.red;
                Invoke("DesactivarTele", jane.clip.length);
                break;
        }
    }

    private void activarReloj()
    {
         // ACTIVA EL RELOJ DURANTE 2 MIN

    }

    public void Buidar()
    {
        jane.clip = null;
    }


    private void desactivarRellotge()
    {
        rellotge.GetComponent<AudioReloj>().DesactivarReloj();
    }

    private void bajarLuz()
    {
        d1.intensity = 0.18f;
        d2.intensity = 0.18f;
        d3.intensity = 0.18f;
        d4.intensity = 0.18f;
    }


}
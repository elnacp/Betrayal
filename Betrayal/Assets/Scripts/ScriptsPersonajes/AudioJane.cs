using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioJane : MonoBehaviour
{

    public GameObject brooke;
    public GameObject alex;
    public GameObject pantallaTele;
    
    


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


    public void ActivateAudio(int num)
    {
        switch (num)
        {

            //AUDIO ESPAÑOL
            case 1:
                pantallaTele.SetActive(true);
                pantallaTele.GetComponent<TelevisorAudio>().ActivarTelevisor();
                jane.clip = audio1;
                jane.Play();
                numeroAudio = 39;
                personatge = 1;
                Invoke("PedirActivar", jane.clip.length + 1);
                break;
            case 2:
                jane.clip = audio2;
                jane.Play();
                Invoke("PedirDesactivar", jane.clip.length + 2);
                break;
            case 3:
                jane.clip = audio3;
                jane.Play();
                break;

       


            case 8:
                pantallaTele.SetActive(true);
                pantallaTele.GetComponent<TelevisorAudio>().ActivarTelevisor();
                jane.clip = audio8;
                jane.Play();
                numeroAudio = 53;
                personatge = 1;
                Invoke("PedirActivar", jane.clip.length + 1);
                break;
            case 9:
                jane.clip = audio9;
                jane.Play();
                Invoke("PedirDesactivar", jane.clip.length +2);
                break;
            case 10:
                jane.clip = audio10;
                jane.Play();
                break;
        }
    }
}
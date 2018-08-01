using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAlex : MonoBehaviour {

    public GameObject mensaje;
    public GameObject brooke;
    public GameObject jane;
    
    

    AudioSource alex;

    //AUDIOS EN ESPAÑOL
    public AudioClip audio33;
    public AudioClip audio34;
    public AudioClip audio35;
    public AudioClip audio36;
    public AudioClip audio37;
    public AudioClip audio38;
    public AudioClip audio39;
    public AudioClip audio40;
    public AudioClip audio41;
    public AudioClip audio42;
    public AudioClip audio43;
    public AudioClip audio44;
    public AudioClip audio45;
    public AudioClip audio46;
    
    //AUDIOS EN INGLES
    public AudioClip audio47;
    public AudioClip audio48;
    public AudioClip audio49;
    public AudioClip audio50;
    public AudioClip audio51;
    public AudioClip audio52;
    public AudioClip audio53;
    public AudioClip audio54;
    public AudioClip audio55;
    public AudioClip audio56;
    public AudioClip audio57;
    public AudioClip audio58;
    public AudioClip audio59;
    public AudioClip audio60;

    private string lang;
    private bool español = false;
    private bool english = false;

    private int personatge;
    private int numeroAudio;


	// Use this for initialization
	void Start () {
        lang = variablesGlobals.lang;
        
        
        if (lang.Equals("español"))
        {
            español = true;
            Wait(5);
            alex = GetComponent<AudioSource>();
            /*alex.clip = audio33;
            alex.Play();
            personatge = 2;
            numeroAudio = 15;
            Invoke("PedirActivar", alex.clip.length);*/
            
            //GetComponent<AudioBrooke>().ActivateAudioBrooke(15); 
            

        }

        if (lang.Equals("english"))
        {
            english = true;
            Wait(30);
            alex = GetComponent<AudioSource>();
            /*alex.clip = audio47;
            alex.Play();
            personatge = 2;
            numeroAudio = 62;
            Invoke("PedirActivar", alex.clip.length);*/
        }

    }

    private void PedirActivar( )
    {
        switch (personatge)
        {
            case 2: // BROOKE
                brooke.GetComponent<AudioBrooke>().ActivateAudio(numeroAudio);
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
            case 34:
                alex.clip = audio34;
                alex.Play();
                numeroAudio = 16;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 35:
                alex.clip = audio35;
                alex.Play();
                numeroAudio = 17;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 36:
                alex.clip = audio36;
                alex.Play();
                break;
            case 37:
                alex.clip = audio37;
                alex.Play();
                break;
            case 38:
                alex.clip = audio38;
                alex.Play();
                //se pide encender las luces
                numeroAudio = 1;
                personatge = 3;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 39:
                alex.clip = audio39;
                alex.Play();
                numeroAudio = 2;
                personatge = 3;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 40:
                alex.clip = audio40;
                alex.Play();
                numeroAudio = 26;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 45:
                alex.clip = audio45;
                alex.Play();
                numeroAudio = 29;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;

            //DIALOGO EN INGLES
            case 48:
                alex.clip = audio48;
                alex.Play();
                numeroAudio = 63;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 49:
                alex.clip = audio49;
                alex.Play();
                numeroAudio = 64;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 50:
                alex.clip = audio50;
                alex.Play();
                break;
            case 51:
                alex.clip = audio51;
                alex.Play();
                break;
            case 52:
                alex.clip = audio52;
                alex.Play();
                numeroAudio = 8;
                personatge = 3;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 53:
                alex.clip = audio53;
                alex.Play();
                numeroAudio = 9;
                personatge = 3;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 54:
                alex.clip = audio54;
                alex.Play();
                numeroAudio = 69;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;
            case 55:
                alex.clip = audio55;
                alex.Play();
                numeroAudio = 72;
                personatge = 2;
                Invoke("PedirActivar", alex.clip.length);
                break;

        }

        
    }




    IEnumerator Wait(int time)
    {
        yield return new WaitForSeconds(time);
    }

}

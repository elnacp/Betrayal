using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text text;
    float theTime;
    public float speed;
    private float time;
    public GameObject jane;

    void Start()
    {
        time = variablesGlobals.time + 10;
        text = GetComponent<Text>();
    }
    void Update()
    {
       
        if (variablesGlobals.playing) {                                 //Cuando Jane indice el contador empieza a disminuir
            if (time >= 0)                                              //En el caso de que el tiempo siga siendo positivo no es final de partida
            {
                time -= Time.deltaTime * speed;                         //coje el tiempo y lo va disminuyendo
                string minutes = ((time % 3600) / 60).ToString("00");   //minutos
                string seconds = (time % 60).ToString("00");            //segundos
                text.text = minutes + ":" + seconds;                    //pinta en el reloj el tiempo que le queda
            }

            if (time < 0)                                               //En el caso de que sea inferior a 0 FINAL DE PARTIDA
            {
                text.text = "FINAAL";
                variablesGlobals.finalPartida = true;
                //todas las variables las ponemos a FALSE
                variablesGlobals.prova3 = false;
                variablesGlobals.prova41 = false;
                variablesGlobals.prova42 = false;
                variablesGlobals.prova43 = false;
                variablesGlobals.prova5 = false;
                variablesGlobals.playing = false;

                if (variablesGlobals.lang.Equals("español"))
                {
                    jane.GetComponent<AudioJane>().ActivateAudio(7);
                }
                if (variablesGlobals.lang.Equals("english"))
                {
                    jane.GetComponent<AudioJane>().ActivateAudio(14);
                }


            }
        }
        


    }



}

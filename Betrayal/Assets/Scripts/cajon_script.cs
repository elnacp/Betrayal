using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajon_script : MonoBehaviour {
    // public Animator anim;
    private bool isOpen;
    private bool isClose;
    private float timer;
    private bool stop;
    

    public float velocity;
    public float animationDuration;

  
    // Use this for initialization
	void Start () {
        //anim = GetComponent<Animator>();	
        isOpen = false;
        isClose = true;
      
	}
	// Update is called once per frame
	void Update () {

        //SI EL CAJON SE ABRE
        if (isOpen)
        {
            //realiza la animacion hasta que el tiempo marque cero
            if (timer > Time.time)
            {
                //realiza un desplazamiento hacia delante porque se esta abriendo
                transform.Translate(-Vector3.up * velocity * Time.deltaTime);
            }
            else{
                //indica que ha finalizado la animacion
                stop = false;
            }
        }
        //SI EL CAJON SE CIERRA
        if (isClose)
        {
            //realiza la animacion hasta que el tiempo marque cero
            if (timer > Time.time)
            {
                //realiza un desplazamiento hacia atras porque se esta cerrando
                transform.Translate(Vector3.up * velocity * Time.deltaTime);
            }else
            {
     
                //indica que ha finalizado la animacion
                stop = false;
            }
            
        }
    }

    void OnTriggerStay(Collider col)
    {

        //EN EL CASO DE QUE CLIQUE LA "A" ABRE EL CAJON
        if(OVRInput.Get(OVRInput.Button.One) ) 
        {
            //Solo se activa si no ha entrado en la animacion y si no ha parado
            if (isClose == true && stop == false)
            {
                isOpen = true;
                isClose = false;
                stop = true;
                timer = Time.time + animationDuration;
            }

        }

        //EN EL CASO DE QUE CLIQUE LA "B" ABRE EL CAJON
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            if(isOpen == true && stop == false)
            {
                isClose = true;
                isOpen = false;
                stop = true;
                timer = Time.time + animationDuration;
            }
           
        }
    }

   
}

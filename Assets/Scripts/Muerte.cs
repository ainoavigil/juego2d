using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject Personaje;

    public GameObject gestorSonido;

    private static int contadorTrigger;

    void Start(){
        contadorTrigger = 0;
    }
 
  
    // Update is called once per frame
    void Update()
    {
        Debug.Log(contadorTrigger);
    }

    void OnTriggerEnter2D(){
            Debug.Log("Has muerto!!");
        // gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<AudioManager>().sonidoMuerte, 1f);
        gestorSonido.GetComponent<AudioManager>().sonidoDead();
        PrincipalScript.Vida--;
        Personaje.transform.position = new Vector2 (-4f, -1.46f);
        
    }

 
}

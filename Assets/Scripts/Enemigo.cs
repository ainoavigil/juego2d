using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
  
  public string clonBala;

  float speedEnemigo = 0.6f; 
  float distanciaPlayer = 4f; 
  Vector3 posicionInicial; 

  public GameObject player; 

  public GameObject gestorSonido;

  private AudioSource emisorEnemigo; 

  void Start(){
    player = GameObject.FindGameObjectWithTag("Player");
    posicionInicial = transform.position; 
    emisorEnemigo = GetComponent<AudioSource>();

  }

  void Update(){
    Vector3 Objetivo = posicionInicial; 
    float distancia = Vector3.Distance(player.transform.position, transform.position);

    if(distancia < distanciaPlayer){
        Objetivo = player.transform.position; 
    }

    float velocidadFija = speedEnemigo*Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, Objetivo, velocidadFija); 

    Debug.DrawLine(transform.position, Objetivo, Color.green); 

  }

  void OnTriggerEnter2D(Collider2D col){
    clonBala = col.gameObject.name;

    if (clonBala == "Balafuego(Clone)") {
        emisorEnemigo.PlayOneShot(gestorSonido.GetComponent<AudioManager>().sonidoBola, 1f);
        PrincipalScript.Enemigos++;
        Destroy(this.gameObject, 0.3f); 
    }
    if (clonBala == "Personaje"){
        PrincipalScript.Vida--; 
         player.transform.position = new Vector2 (-4f, -1.46f);
         gestorSonido.GetComponent<AudioManager>().sonidoDead();
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipalScript : MonoBehaviour
{

    public static int Score = 0;
    public static int Vida = 3;
    public static int Enemigos = 0;
    public GUISkin miSkin;
    public Texture2D logoJuego;
    int anchoPantalla;

    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anchoPantalla = Screen.width/2;

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }

        // Debug.Log("Vida "+Vida);
        // Debug.Log("Score "+Score);
        // Debug.Log("Enemigos "+Enemigos);
        
    }

    // OnGUI no lee numeros enteros. Necesitamos cambiar vida a string con el conversor: .ToString()
    void OnGUI(){
        GUI.skin = miSkin;
        GUI.Label(new Rect(20,20,150,80),"Vida: "+Vida.ToString(), "estiloScore");
        GUI.Label(new Rect(80,20,150,80),"Score: "+Score.ToString(), "estiloScore");
        GUI.Label(new Rect(140,20,150,80),"Enemigos: "+Enemigos.ToString(), "estiloScore");
        GUI.Label(new Rect(anchoPantalla-70,20,200,100),"Nombre Juego", "estiloTitulo");
        // Imagen
        GUI.DrawTexture(new Rect(Screen.width-100,20,80,80),logoJuego);
    }
}

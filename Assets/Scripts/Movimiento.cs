using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public static float velocidad = 2f;
    public bool ActivaSalto = true;
    public float Salto = 5;

    public Animator controlAnimacion;

    public static bool direccionBala = false; 
    public static bool pararDireccionBala = false;

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

        if(PrincipalScript.Vida > 0){

            float H = Input.GetAxis("Horizontal")*velocidad;
            H *= Time.deltaTime;
            transform.Translate (H,0,0);

            // Inputs de control no predefinidos

            // salto
            if (Input.GetKey(KeyCode.Space) && ActivaSalto == true ){
                ActivaSalto = false;
                GetComponent<Rigidbody2D> ().AddForce (new Vector2(0,Salto),ForceMode2D.Impulse);
            }


            if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
                transform.localScale = new Vector3(1,1,1);
                controlAnimacion.SetBool("activacamina", true);
                direccionBala = true;
                pararDireccionBala = true;
                Parallax.DireccionPersonaje = "derecha";
            }

            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
                transform.localScale = new Vector3(-1,1,1);
                controlAnimacion.SetBool("activacamina", true);
                direccionBala = false;
                Parallax.DireccionPersonaje = "izquierda";
            }
            
            if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
                controlAnimacion.SetBool("activacamina", false);
                pararDireccionBala = false;
                Parallax.DireccionPersonaje = "parado";
            }

            if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
                controlAnimacion.SetBool("activacamina", false);
                pararDireccionBala = true;
                Parallax.DireccionPersonaje = "parado";
            }


        }
        

    }

    void OnCollisionEnter2D(Collision2D col){
        ActivaSalto = true;
    }
}

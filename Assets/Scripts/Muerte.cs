using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject Personaje;

  
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(){
        Debug.Log("Has muerto!!");
        PrincipalScript.Vida--;
        Personaje.transform.position = new Vector2 (-4f, -1.46f);
    }
}

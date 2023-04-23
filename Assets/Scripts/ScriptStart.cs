using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptStart : MonoBehaviour
{

    public GameObject CanvasStart;

    public GameObject CanvasControles;


    // Start is called before the first frame update
    void Start()
    {
        CanvasControles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrarJuego(){
        SceneManager.LoadScene("nivel1");
    }

    public void MostrarControles(){
        CanvasStart.SetActive(false);
        CanvasControles.SetActive(true);
    }

    public void Volver(){
        CanvasControles.SetActive(false);
        CanvasStart.SetActive(true);
    }
}

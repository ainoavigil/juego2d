using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {

        if(Input.GetKeyDown(KeyCode.X) == true){
            Instantiate (bala, new Vector2(transform.position.x, transform.position.y), transform.rotation);
        }
        

        
    }
}

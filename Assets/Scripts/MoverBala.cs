using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Movimiento.direccionBala == true && Movimiento.pararDireccionBala == false){
            transform.Translate (new Vector2 (Time.deltaTime * 6,0)); 
        }
        if(Movimiento.direccionBala == false && Movimiento.pararDireccionBala == true){
            transform.Translate (new Vector2 (-Time.deltaTime * 6,0)); 
        }
        
    }
}

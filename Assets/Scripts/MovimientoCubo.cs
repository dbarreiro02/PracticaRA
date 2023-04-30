using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad =  50;
        
    }

    // Update is called once per frame
    void Update(){ 
        transform.Rotate(new Vector3(0f,10f,0f) * velocidad * Time.deltaTime); 
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime); 
    }
}

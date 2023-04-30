using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
            transform.Translate(Vector3.forward);
        if(Input.GetKey(KeyCode.S)) 
            transform.Translate(Vector3.back);
        if(Input.GetKey(KeyCode.A)) 
            transform.Translate(Vector3.left);
        if(Input.GetKey(KeyCode.D)) 
            transform.Translate(Vector3.right);  
        if(Input.GetKey(KeyCode.Q)) 
            transform.Translate(Vector3.up);
        if(Input.GetKey(KeyCode.E)) 
            transform.Translate(Vector3.down);
        if(Input.GetKey(KeyCode.UpArrow)) 
            transform.Rotate(new Vector3(-1f,0f,0f)); 
        if(Input.GetKey(KeyCode.DownArrow)) 
            transform.Rotate(new Vector3( 1f,0f,0f)); 
        if(Input.GetKey(KeyCode.LeftArrow)) 
            transform.Rotate(new Vector3(0f,-1f,0f), Space.World); 
        if(Input.GetKey(KeyCode.RightArrow)) 
            transform.Rotate(new Vector3(0f, 1f,0f), Space.World);  
    }
}

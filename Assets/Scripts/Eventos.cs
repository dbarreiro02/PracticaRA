using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eventos : MonoBehaviour
{

    public Image img;
    public Button buttonMostrar;
    public Button buttonOcultar;

    // Start is called before the first frame update
    void Start()
    {
        img.enabled = true;  
        buttonMostrar.interactable = false;
        buttonOcultar.interactable = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mostrarImagen() {
        img.enabled = true;   
        buttonMostrar.interactable = false;
        buttonOcultar.interactable = true; 
    }

    public void ocultarImagen() {
        img.enabled = false;   
        buttonMostrar.interactable = true;
        buttonOcultar.interactable = false; 
    }

    public void salirAplicacion() { 
        Application.Quit(); 
    }
}


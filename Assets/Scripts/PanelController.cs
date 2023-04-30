using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelController : MonoBehaviour
{

    public GameObject panelCuadrado;
    public GameObject panelRectangulo;

    // Start is called before the first frame update
    void Start()
    {
        panelCuadrado.SetActive(false);
        panelRectangulo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mostrarPanelOpcionesCuadrado() {
        panelCuadrado.SetActive(true);
        panelRectangulo.SetActive(false);
    }

    public void mostrarPanelOpcionesRectangulo() {
        panelRectangulo.SetActive(true);
        panelCuadrado.SetActive(false);
    }

    public void ocultarPanel() {
        panelCuadrado.SetActive(false);
        panelRectangulo.SetActive(false);
    }
}

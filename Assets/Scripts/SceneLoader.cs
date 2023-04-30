using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneLoader : MonoBehaviour
{
    public List<Scene> scenesToLoad; // Lista de objetos de tipo escena que se cargarán

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(scenesToLoad[index].name);
    }
}

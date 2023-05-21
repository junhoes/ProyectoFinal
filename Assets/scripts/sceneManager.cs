using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void irAEscena(int i)  //i -> numero de la escena
    {
        SceneManager.LoadScene(i);
    }
    public void Salir()
    {
        Application.Quit();
    }
}

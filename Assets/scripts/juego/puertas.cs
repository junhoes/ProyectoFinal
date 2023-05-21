using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puertas : MonoBehaviour
{
    public int casa;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            irACasa(casa);
        }
    }
    public void irACasa(int i)  //i -> numero de la escena
    {
        SceneManager.LoadScene(i);
    }
    //meter una corrutina para que no sea directa la entrada
}

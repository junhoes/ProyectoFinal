using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogoCasa1 : MonoBehaviour
{
    public TextMeshProUGUI t_dialogo;
    public string[] sentences;
    public float textSpeed;

    private int index;

    public GameObject btn_continuar;
    private void Start()
    {
        StartCoroutine(Type());
        btn_continuar.SetActive(false);
    }
    private void Update()
    {
        if (t_dialogo.text == sentences[index])
        {
            btn_continuar.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            t_dialogo.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    public void NextSentence()
    {
        btn_continuar.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            t_dialogo.text = "";
            StartCoroutine(Type());
        }
        else
        {
            t_dialogo.text = "";
        }
    }

}

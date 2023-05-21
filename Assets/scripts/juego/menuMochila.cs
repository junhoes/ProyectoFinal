using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using DG.Tweening;

public class menuMochila : MonoBehaviour
{
    [SerializeField] GameObject mochila;
    [SerializeField] Image i_mochila;

    [SerializeField] Vector3 posMoch;

    private void Start()
    {
        DOTween.Init();
        posMoch = this.transform.position;
        mochila.SetActive(false);
    }
    public void apareceMenu()
    {
        mochila.SetActive(true);
        i_mochila.transform.DOMove(posMoch, 2).SetEase(Ease.OutElastic);     
    }
    public void cerrarMenu()
    {
        mochila.SetActive(false);
        //meter otro dotweens de salida?
    }

}

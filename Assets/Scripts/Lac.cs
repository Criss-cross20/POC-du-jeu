using UnityEngine;
using System.Collections;

public class Lac : MonoBehaviour
{
    public GameObject Choix6Panel;
    public GameObject Eau;
    public GameObject SacADos;
    public GameObject Animal;



    public void LacChoix1()
    {
        Choix6Panel.SetActive(false);
        StartCoroutine(FreezeRoutine());

    }

    IEnumerator FreezeRoutine()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(30f);
        Time.timeScale = 1f;
    }
    public void LacChoix2()
    {
        Choix6Panel.SetActive(false);
        Destroy(Animal);
        Eau.GetComponent<Renderer>().material.color=Color.brown;



    }
}

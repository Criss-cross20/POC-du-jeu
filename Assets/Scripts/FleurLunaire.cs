using UnityEngine;
using System.Collections;


public class FleurLunaire : MonoBehaviour
{
    
    public GameObject FleursLunaires;
    public GameObject Choix4Panel;


    public void FleurChoix1()
    {
        Choix4Panel.SetActive(false);
        StartCoroutine(FreezeRoutine());



    }

    IEnumerator FreezeRoutine()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(30f);
        Time.timeScale = 1f;
    }

    public void FleurChoix2()
    {
        Choix4Panel.SetActive(false);
        Destroy(FleursLunaires);
        


    }
}

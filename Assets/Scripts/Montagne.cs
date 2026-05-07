using UnityEngine;
using System.Collections;

public class Montagne : MonoBehaviour
{
   public GameObject Choix9Panel;
   public GameObject Neige;
   public GameObject CubeRouge;
   


   public void MontagneChoix1()
    {
        Choix9Panel.SetActive(false);
        StartCoroutine(FreezeRoutine());
        Destroy(CubeRouge);
        
    }
     IEnumerator FreezeRoutine()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(30f);
        Time.timeScale = 1f;
    }

    public void MontagneChoix2()
    {
        Choix9Panel.SetActive(false);
        Destroy(Neige);
        Destroy(CubeRouge);

    }
}

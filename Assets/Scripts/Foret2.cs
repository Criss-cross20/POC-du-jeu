using UnityEngine;
using System.Collections;

public class Foret2 : MonoBehaviour
{

  
  public GameObject ArbreCoupe;
  public GameObject Arbre;
  public GameObject Choix4Panel;
  public GameObject AutreArbre;
  public GameObject AutreArbre2;


  public void Foret2Choix1()
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

  public void Foret2Choix2()
  {
    Choix4Panel.SetActive(false);
    Destroy(Arbre);
    Instantiate(ArbreCoupe, new Vector3(85, -1, 0), Quaternion.identity);
    Destroy(AutreArbre);
    Destroy(AutreArbre2);


  }


  
}

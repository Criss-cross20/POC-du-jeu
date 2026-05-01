using UnityEngine;
using UnityEngine.SceneManagement;

public class Choix2 : MonoBehaviour
{
  public GameObject Choix2Panel;
  public GameObject Choix1Panel;
  public GameObject Choix4Panel;
  public GameObject Choix3Panel;
  public GameObject Choix5Panel;
  public GameObject Choix6Panel;
  public GameObject Choix7Panel;
  public GameObject Choix8Panel;

  public void ChampLoad()
  {
    Choix2Panel.SetActive(true);
    Choix1Panel.SetActive(false);
    Choix4Panel.SetActive(false);
    Choix3Panel.SetActive(false);
    Choix5Panel.SetActive(false);
    Choix6Panel.SetActive(false);
    Choix7Panel.SetActive(false);
    Choix8Panel.SetActive(false);
    
    

  }
}

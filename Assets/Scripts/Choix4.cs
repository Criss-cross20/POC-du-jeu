using UnityEngine;

public class Choix4 : MonoBehaviour
{
  public GameObject Choix1Panel;
  public GameObject Choix2Panel;
  public GameObject Choix4Panel;

  public void Choix4Load()
  {
    Choix1Panel.SetActive(false);
    Choix2Panel.SetActive(false);
    Choix4Panel.SetActive(true);
    

  }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Choix2 : MonoBehaviour
{
  public GameObject Choix2Panel;
  public GameObject Choix1Panel;
  public void ChampLoad()
  {
    Choix2Panel.SetActive(true);
    Choix1Panel.SetActive(false);

  }
}

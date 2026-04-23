using UnityEngine;
using UnityEngine.SceneManagement;

public class Choix1 : MonoBehaviour
{
public GameObject Choix1Panel;
public GameObject Choix2Panel;

  public void ForetLoad()
  {
    Choix1Panel.SetActive(true);
    Choix2Panel.SetActive(false);
    

  }
}

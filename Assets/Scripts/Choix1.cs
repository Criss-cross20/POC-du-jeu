using UnityEngine;
using UnityEngine.SceneManagement;

public class Choix1 : MonoBehaviour
{
public GameObject Choix1Panel;
public GameObject Choix2Panel;
public GameObject Choix4Panel;
public GameObject Choix3Panel;
public GameObject Choix5Panel;
public GameObject Choix6Panel;
public GameObject Choix7Panel;
public GameObject Choix8Panel;


  public void ForetLoad()
  {
    Choix1Panel.SetActive(true);
    Choix2Panel.SetActive(false);
    Choix4Panel.SetActive(false);
    Choix3Panel.SetActive(false);
    Choix5Panel.SetActive(false);
    Choix6Panel.SetActive(false);
    Choix7Panel.SetActive(false);
    Choix8Panel.SetActive(false);
    
    


  }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Choix3 : MonoBehaviour
{
   public GameObject Choix1Panel;
   public GameObject Choix2Panel;
   public GameObject Choix3Panel;
   public GameObject Choix4Panel;
   public GameObject Choix5Panel;
   public GameObject Choix6Panel;
   public GameObject Choix7Panel;
   public GameObject Choix8Panel;
   public GameObject Choix9Panel;
   public GameObject Choix10Panel;


 public void Choix3Load()
 {
   Choix1Panel.SetActive(false);
   Choix2Panel.SetActive(false);
   Choix3Panel.SetActive(true);
   Choix4Panel.SetActive(false);
   Choix5Panel.SetActive(false);
   Choix6Panel.SetActive(false);
   Choix7Panel.SetActive(false);
   Choix8Panel.SetActive(false);
   Choix9Panel.SetActive(false);
   Choix10Panel.SetActive(false);
   
   
 }
}

using UnityEngine;

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

  }

  public void Foret2Choix2()
  {
    Choix4Panel.SetActive(false);
    Destroy(Arbre);
    Instantiate(ArbreCoupe, new Vector3(109, 1, 0), Quaternion.Euler(0, 0, -1));
    Destroy(AutreArbre);
    Destroy(AutreArbre2);


  }


  
}

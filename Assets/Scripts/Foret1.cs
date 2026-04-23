using UnityEngine;

public class Foret1 : MonoBehaviour
{
    public GameObject Choix1Panel;
    public GameObject Animal;
    public GameObject Brouillard;



   public void ForetChoix1()
   {
    Choix1Panel.SetActive(false);
   }

   public void ForetChoix2()
   {
    Choix1Panel.SetActive(false);
    Destroy(Animal);
    Instantiate(Brouillard, new Vector3(105, 8, 0), Quaternion.identity);

   }
}

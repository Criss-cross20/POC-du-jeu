using UnityEngine;

public class Nuit : MonoBehaviour
{
   public GameObject Choix7Panel;
   public GameObject Bouteille1;
   public GameObject Bouteille2;
   public GameObject Bouteille3;

   public void NuitChoix1()
    {
        Choix7Panel.SetActive(false);

    }
    public void NuitChoix2()
    {
        Choix7Panel.SetActive(false);
        Instantiate(Bouteille1, new Vector3(149, -5, 1), Quaternion.Euler(0, -1, 0));
        Instantiate(Bouteille2, new Vector3(175, -2, 0), Quaternion.Euler(0, 0, 92));
        Instantiate(Bouteille3, new Vector3(162, -2, 0), Quaternion.Euler(0, 0, -49));
    }
}

using UnityEngine;

public class Montagne : MonoBehaviour
{
   public GameObject Choix9Panel;
   public GameObject Neige;
   public GameObject CubeRouge;
   

   public void MontagneChoix1()
    {
        Choix9Panel.SetActive(false);
    }

    public void MontagneChoix2()
    {
        Choix9Panel.SetActive(false);
        Destroy(Neige);
        Destroy(CubeRouge);

    }
}

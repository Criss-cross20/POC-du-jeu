using UnityEngine;


public class Champ1 : MonoBehaviour
{
    public GameObject Fleur;
    public GameObject Choix2Panel;
    public GameObject ArcEnCiel;



    public void ChampChoix1()
    {
        Choix2Panel.SetActive(false);
    }

    public void ChampChoix2()
    {
        Choix2Panel.SetActive(false);
        Destroy(Fleur);
        Destroy(ArcEnCiel);
        
    }
}

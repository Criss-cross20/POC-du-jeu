using UnityEngine;


public class Champ1 : MonoBehaviour
{
    public GameObject Fleur;
    public GameObject Fleur2;
    public GameObject Fleur3;
    public GameObject Fleur4;
    public GameObject Fleur5;
    public GameObject Fleur6;

    public GameObject Choix2Panel;
    



    public void ChampChoix1()
    {
        Choix2Panel.SetActive(false);
    }

    public void ChampChoix2()
    {
        Choix2Panel.SetActive(false);
        Destroy(Fleur);
        Destroy(Fleur2);
        Destroy(Fleur3);
        Destroy(Fleur4);
        Destroy(Fleur5);
        Destroy(Fleur6);

        
        
    }
}

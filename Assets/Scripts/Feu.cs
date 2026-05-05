using UnityEngine;

public class Feu : MonoBehaviour
{
    public GameObject Feu0;
    public GameObject Feu2;
    public GameObject Feu3;
    public GameObject Feu4;
    public GameObject Feu5;
    public GameObject Feu6;
    public GameObject Feu7;
    public GameObject Fumee;
    public GameObject Choix10Panel;
    public GameObject Flashlight;
    public GameObject Batterie1;
    public GameObject Batterie2;
    


    public void FeuChoix1Load()
    {
        Choix10Panel.SetActive(false);

    }

    public void FeuChoix2Load()
    {
        Choix10Panel.SetActive(false);
        Instantiate(Feu0, new Vector3(187, -7, 0), Quaternion.identity);
        Instantiate(Feu2, new Vector3(193, -1, 0), Quaternion.identity);
        Instantiate(Feu3, new Vector3(194, 1, 0), Quaternion.identity);
        Instantiate(Feu4, new Vector3(205, -3, 0), Quaternion.identity);
        Instantiate(Feu5, new Vector3(199, -3, 0), Quaternion.identity);
        Instantiate(Feu6, new Vector3(198, -7, 0), Quaternion.identity);
        Instantiate(Feu7, new Vector3(192, -5, 0), Quaternion.identity);
        Instantiate(Fumee, new Vector3(203, 4, 0), Quaternion.identity);
        
    }
}

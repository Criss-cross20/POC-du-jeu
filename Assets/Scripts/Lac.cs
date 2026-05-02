using UnityEngine;

public class Lac : MonoBehaviour
{
    public GameObject Choix6Panel;
    public GameObject Eau;
    public GameObject SacADos;
    public GameObject Animal;



    public void LacChoix1()
    {
        Choix6Panel.SetActive(false);
        

    }
    public void LacChoix2()
    {
        Choix6Panel.SetActive(false);
        Destroy(Animal);
        Eau.GetComponent<Renderer>().material.color=Color.brown;



    }
}

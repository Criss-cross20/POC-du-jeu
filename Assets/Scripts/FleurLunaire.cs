using UnityEngine;

public class FleurLunaire : MonoBehaviour
{
    
    public GameObject FleursLunaires;
    public GameObject Choix4Panel;


    public void FleurChoix1()
    {
        Choix4Panel.SetActive(false);


    }

    public void FleurChoix2()
    {
        Choix4Panel.SetActive(false);
        Destroy(FleursLunaires);
        


    }
}

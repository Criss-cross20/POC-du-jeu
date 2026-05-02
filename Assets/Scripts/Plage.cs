using UnityEngine;

public class Plage : MonoBehaviour
{
    public GameObject Choix5Panel;
    public GameObject Animal;
    public GameObject BackgroundColour;

    public void PlageChoix1()
    {
        Choix5Panel.SetActive(false);
    }
    public void PlageChoix2()
    {
        Choix5Panel.SetActive(false);
        Destroy(Animal);
        Instantiate(BackgroundColour, new Vector3(205, -6, 0), Quaternion.identity);
    }

}

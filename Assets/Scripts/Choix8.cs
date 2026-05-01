using UnityEngine;

public class Choix8 : MonoBehaviour
{
    public GameObject Choix1Panel;
    public GameObject Choix2Panel;
    public GameObject Choix3Panel;
    public GameObject Choix4Panel;
    public GameObject Choix5Panel;
    public GameObject Choix6Panel;
    public GameObject Choix7Panel;
    public GameObject Choix8Panel;

    public void Choix8Load()
    {
        Choix1Panel.SetActive(false);
        Choix2Panel.SetActive(false);
        Choix3Panel.SetActive(false);
        Choix4Panel.SetActive(false);
        Choix5Panel.SetActive(false);
        Choix6Panel.SetActive(false);
        Choix7Panel.SetActive(false);
        Choix8Panel.SetActive(true);

    }
}

using UnityEngine;
using UnityEngine.SceneManagement;


public class Champ1 : MonoBehaviour
{
    public GameObject Fleur;

    public void ChampChoix1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChampChoix2()
    {
        SceneManager.LoadScene("SampleScene");
        Destroy(Fleur);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;


public class Quitter : MonoBehaviour
{


    public void QuitterChoix1()
    {
        SceneManager.LoadScene("GameOver");
    }


}

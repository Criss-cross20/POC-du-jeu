using UnityEngine;
using UnityEngine.SceneManagement; 

public class StartMenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnExitClick()
    {
        
        
        Debug.Log("Quit");
        Application.Quit();

    }
}

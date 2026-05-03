using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject objectifPanel;     // The text box panel
    public GameObject mainMenuGroup;     // The menu buttons + title

    // Show the objectif panel and hide the menu
    public void ShowObjectif()
    {
        objectifPanel.SetActive(true);
        mainMenuGroup.SetActive(false);
    }

    // Hide the objectif panel and show the menu again
    public void HideObjectif()
    {
        objectifPanel.SetActive(false);
        mainMenuGroup.SetActive(true);
    }

    // Start the game
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // Must match your scene name exactly
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game closed."); // Works only in build, not in editor
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject objectifPanel;     // The full-screen text panel
    public GameObject mainMenuGroup;     // The parent object containing the menu buttons + title

    // Show the objectif panel and hide the menu
    public void ShowObjectif()
    {
        mainMenuGroup.SetActive(false);
        objectifPanel.SetActive(true);
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
        SceneManager.LoadScene("SampleScene"); // Replace with your game scene name
    }

    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game closed."); // Only visible in build
    }
}



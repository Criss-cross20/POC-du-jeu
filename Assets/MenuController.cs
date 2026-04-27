using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject objectifPanel;
    public GameObject mainMenu;

    public void ShowObjectifPanel()
    {
        mainMenu.SetActive(false);
        objectifPanel.SetActive(true);
    }

    public void ShowMainMenu()
    {
        objectifPanel.SetActive(false);
        mainMenu.SetActive(true);
    }
}

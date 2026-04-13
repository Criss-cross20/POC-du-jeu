using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public GameObject option1Button;
    public GameObject option2Button;

    public void ChooseOption1()
    {
        // Your game logic here
        HideButtons();
    }

    public void ChooseOption2()
    {
        // Your game logic here
        HideButtons();
    }

    void HideButtons()
    {
        option1Button.SetActive(false);
        option2Button.SetActive(false);
    }
}

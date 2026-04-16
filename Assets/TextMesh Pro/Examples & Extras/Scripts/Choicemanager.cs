using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public GameObject option1Button;
    public GameObject option2Button;
    public GameObject backgroundButton;

    void Start()
    {
        //Hide them at the start
        option1Button.SetActive(false);
        option2Button.SetActive(false);
        backgroundButton.SetActive(false);

        //Show them when the game starts
        ShowChoices();
    }

      public void ShowChoices()
    {
        option1Button.SetActive(true);
        option2Button.SetActive(true);
        backgroundButton.SetActive(true);
    }

    public void HideChoices()
    {
        option1Button.SetActive(false);
        option2Button.SetActive(false);
        backgroundButton.SetActive(false);
    }

    public void ChooseOption1()
    {
        // whatever Option 1 does
        HideChoices();
    }

    public void ChooseOption2()
    {
        // whatever Option 2 does
        HideChoices();
    }
}
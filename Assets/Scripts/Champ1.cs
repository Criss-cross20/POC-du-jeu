using UnityEngine;


public class Champ1 : MonoBehaviour
{
    public GameObject Fleur;
    public GameObject Fleur2;
    public GameObject Fleur3;
    public GameObject Fleur4;
    public GameObject Fleur5;
    public GameObject Fleur6;

    public GameObject Choix2Panel;
    public float timertime;
   public bool TimerBool = false;

   public GameObject Blackout;
    



    public void ChampChoix1()
    {
        Choix2Panel.SetActive(false);
        TimerBool = true;
    }

    public void ChampChoix2()
    {
        Choix2Panel.SetActive(false);
        Destroy(Fleur);
        Destroy(Fleur2);
        Destroy(Fleur3);
        Destroy(Fleur4);
        Destroy(Fleur5);
        Destroy(Fleur6);

        
        
    }
    public void Update()
    {
        if(TimerBool == true)
        {
            Blackout.SetActive(true);
            timertime = timertime+ Time.deltaTime;
        }
        if(timertime>= 10f)
        {
            Blackout.SetActive(false);
            TimerBool = false;
            timertime=0;
        }
    }
}

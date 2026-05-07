using UnityEngine;
using System.Collections;


public class FleurLunaire : MonoBehaviour
{
    
    public GameObject FleursLunaires;
    public GameObject Choix4Panel;
    public float timertime;
   public bool TimerBool = false;

   public GameObject Blackout;
   


    public void FleurChoix1()
    {
        Choix4Panel.SetActive(false);
        TimerBool = true;



    }

    public void FleurChoix2()
    {
        Choix4Panel.SetActive(false);
        Destroy(FleursLunaires);
        


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

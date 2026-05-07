using UnityEngine;
using System.Collections;

public class Montagne : MonoBehaviour
{
   public GameObject Choix9Panel;
   public GameObject Neige;
   public GameObject CubeRouge;

    public float timertime;
   public bool TimerBool = false;

   public GameObject Blackout;
   


   public void MontagneChoix1()
    {
        Choix9Panel.SetActive(false);
        TimerBool = true;
        Destroy(CubeRouge);
        
    }
    

    public void MontagneChoix2()
    {
        Choix9Panel.SetActive(false);
        Destroy(Neige);
        Destroy(CubeRouge);

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

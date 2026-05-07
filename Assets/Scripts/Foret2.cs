using UnityEngine;
using System.Collections;

public class Foret2 : MonoBehaviour
{

  
  public GameObject ArbreCoupe;
  public GameObject Arbre;
  public GameObject Choix4Panel;
  public GameObject AutreArbre;
  public GameObject AutreArbre2;
  public float timertime;
   public bool TimerBool = false;

   public GameObject Blackout;
   


  public void Foret2Choix1()
  {
    Choix4Panel.SetActive(false);
    TimerBool = true;

  }
 
  public void Foret2Choix2()
  {
    Choix4Panel.SetActive(false);
    Destroy(Arbre);
    Instantiate(ArbreCoupe, new Vector3(85, -1, 0), Quaternion.identity);
    Destroy(AutreArbre);
    Destroy(AutreArbre2);


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

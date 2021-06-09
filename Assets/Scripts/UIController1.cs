using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController1 : MonoBehaviour
{
    public GameObject startUI;
   // public float clocktimer = 14.0f;
   // public float lighttimer = 30.0f;
   // private bool isclk = false;
    //private bool islight = false;
    
    //public List<GameObject> framelight;
    void Start()
    {
        Destroy(startUI, 10.0f);
       // isclk = true;
        //islight = true;
    }
    void Update()
    {

       /*  if (islight)
        {
            if (lighttimer > 0)
            {
                lighttimer -= Time.deltaTime;
                //Debug.Log(clocktimer);
               

            }
            else
            {

               lighttimer = 35.0f;
              
                lightos.Play();
            }
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

}

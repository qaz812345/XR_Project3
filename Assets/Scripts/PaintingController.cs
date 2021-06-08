using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject startUI;
    //public GameObject ipad;
   // public List<Material> skyboxes;
   // public List<Painting> correct_paintings;
    //public List<Painting> incorrect_paintings;
    //public List<GameObject> paintings;
    //public GameObject resultUI;
    
    //public Text resultText, titleText, titleENText, authorText, yearText, infoText;
    //public GameObject correct_borad, incorrect_borad;
    //private int correct_counter = 0;

    void Start()
    {
        Destroy(startUI,10.0f);
        
    }

    public void loadInfo(int input)
    {
        int no = (input / 10) - 1;
        int ans = input % 10;
        
        //ans 0 -> false, 1 -> true
        if (ans == 1) // Correct
        {
            
        }
        else // Incorrect
        {
          
        }
    }

    public void close(int butt)
    {
        int cls = butt;
        if(cls == 1)
                startUI.SetActive(false);
            
                
          
    }
    public void open(int butt)
    {
        int op = butt;
        

    }
    private void SetSkybox(int no)
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject startUI; 
    public GameObject ipad;
    public List<Material> skyboxes;
    public List<Painting> correct_paintings;
    public List<Painting> incorrect_paintings;
    public List<GameObject> paintings;
    public GameObject resultUI;
    
    public Text resultText, titleText, titleENText, authorText, yearText, infoText;
    public GameObject correct_borad, incorrect_borad;
    private int correct_counter = 0;

    void Start()
    {
        Destroy(startUI,5.0f);
        ipad.SetActive(false);
        resultUI.SetActive(false);
        correct_borad.SetActive(false);
        incorrect_borad.SetActive(false);
    }

    
    public void close(int butt)
    {
        int cls = butt;
        if(cls == 1)
            startUI.SetActive(false);

        else    
            resultUI.SetActive(false);      
    }

    public void open(int butt)
    {
        int op = butt;
        if (op == 1)
            ipad.SetActive(true);
        else
            ipad.SetActive(false);
    }

    private void SetSkybox(int no)
    {
        
    }
}

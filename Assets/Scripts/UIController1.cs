using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController1 : MonoBehaviour
{
    public GameObject startUI;
   


    void Start()
    {
        Destroy(startUI, 5.0f); 
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    public Material[] sky;
    int indext;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeSkyBox", 0, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeSkyBox()
    {
        RenderSettings.skybox = sky[indext];
        indext ++;
        indext %= sky.Length;
    }
}

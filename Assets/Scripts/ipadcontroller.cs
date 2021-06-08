using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ipadcontroller : MonoBehaviour
{
    public Image Camera;
    public Image[] Frame;
    public Sprite[] Picture;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ImgUpload(int a)
    {
        int ans = a;
        if(ans == 10)
        {
            for (int num = 0; num <= 1; ++num)
            {
                Frame[num].sprite = Picture[num];
            }
        }
        else
            Frame[ans].sprite = Picture[ans];
    }
}

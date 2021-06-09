using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ipadcontroller : MonoBehaviour
{
    public Image Camera;

    public Image[] Frame;
    public Sprite[] Picture;
    public AudioSource upload_sound;


    // Start is called before the first frame update
    void Start()
    {
        
        Color trans = Camera.color;
        trans.a = 0;
        Camera.color = trans;
        //Camera.SetActive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImgUpload(int a)
    {
        int ans = a;
        if (ans == 10)
        {
            for (int num = 0; num <= 1; ++num)
            {
                Frame[num].sprite = Picture[num];
                upload_sound.Play();
            }
        }
        else
        {
            Frame[ans].sprite = Picture[ans];

            //Camera.color.a = 0;
        }

    }
    public void Selfie()
    {
        Color trans = Camera.color;
        trans.a = 1;
        Camera.color = trans;

            upload_sound.Play();
            

    }
}

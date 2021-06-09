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

    public void ImgUpload(int a)
    {
        int ans = a;
        if(ans == 10)
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
            upload_sound.Play();
        }      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeimg : MonoBehaviour
{
    [SerializeField] flashimg flashImg;
    [SerializeField] flashlight camlight;
    [SerializeField] Color flashcolor = Color.white;
    [SerializeField] Color lightcolor = Color.white;
    public Image oldImg;
    public Sprite newImg;
    public Image clickImg;
    public GameObject ipad;
    // public Image flashImg;

    // Start is called before the first frame update
    void Start()
    {
        //ipad.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //lightflash();
        //flashimg();
    }
    public void ImgChange()
    {

        oldImg.sprite = newImg;

    }
    public void ImgtoChange()
    {

        oldImg.sprite = clickImg.sprite;

    }
    public void Flashimg()
    {
        flashImg.StartFlashimg(.25f, .5f, flashcolor);
    }
    public void Lightflash()
    {
        camlight.StartFlashlight(.25f, .6f, 30.0f, lightcolor);
    }
    public void loadInfo(int input)
    {
        int no = (input / 10) - 1;
        int ans = input % 10;
        if (ans == 1)
            ipad.SetActive(true);
        else
            ipad.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintingController : MonoBehaviour
{
    public GameObject startUI;
    public GameObject ipad;
    public List<Material> skyboxes;
    public List<Painting> correct_paintings;
    public List<Painting> incorrect_paintings;
    public List<GameObject> paintings;
    public List<AudioSource> hint_sounds;
    public GameObject resultUI;
    public Text resultText, titleText, titleENText, authorText, yearText, infoText;
    public GameObject correct_borad, incorrect_borad;
    public AudioSource window_pop, window_close, correct_sound, incorrect_sound, star_sound;
    private int correct_counter = 0;
    private bool current_result = false;

    void Start()
    {
        Destroy(startUI,5.0f);
        ipad.SetActive(false);
        resultUI.SetActive(false);
        correct_borad.SetActive(false);
        incorrect_borad.SetActive(false);
    }

    public void loadInfo(int input)
    {
        int no = (input / 10) - 1;
        int ans = input % 10;
        resultUI.SetActive(true);
        hint_sounds[no].Stop();
        //ans 0 -> false, 1 -> true
        if (ans == 1) // Correct
        {
            correct_sound.Play();
            paintings[no].SetActive(false);
            incorrect_borad.SetActive(false);
            correct_borad.SetActive(true);
            resultText.text = "太棒了就是這個!";
            titleText.text = "《" + correct_paintings[no].title + "》";
            titleENText.text = correct_paintings[no].title_en;
            authorText.text = "作者：" + correct_paintings[no].author;
            yearText.text = "年份：" + correct_paintings[no].year;
            infoText.text = correct_paintings[no].description;
            correct_counter += 1;
            current_result = true;
            SetSkybox(correct_counter);
        }
        else // Incorrect
        {
            incorrect_sound.Play();
            paintings[no].SetActive(false);
            correct_borad.SetActive(false);
            incorrect_borad.SetActive(true);
            resultText.text = "這不是梵谷的畫...";
            titleText.text = "《" + incorrect_paintings[no].title + "》";
            titleENText.text = incorrect_paintings[no].title_en;
            authorText.text = "作者：" + incorrect_paintings[no].author;
            yearText.text = "年份：" + incorrect_paintings[no].year;
            infoText.text = "";
        }
    }

    public void close(int butt)
    {
        int cls = butt;
        if (cls == 1)
                startUI.SetActive(false);
        else
        {
            resultUI.SetActive(false);
            if (current_result)
            {
                star_sound.Play();
                current_result = false;
            }
            else
            {
                window_close.Play();
            }
 
        }
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
        RenderSettings.skybox = skyboxes[no];
    }
}

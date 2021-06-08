using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuestionController : MonoBehaviour
{
    public List<Button> titles;
    public List<GameObject> questions;
    public GameObject questionUI;
    public GameObject resultUI;
    public List<GameObject> buttons;
    public AudioSource window_pop, window_close, correct_sound, incorrect_sound, bingo_sound;
    public Animator boss_animator;
    private Text questionText;
    private Text resultText;
    private Text bingoText;
    private int curQuesNo = -1;
    private bool[,] jiugongge = new bool[3,3]{{false, false, false}, {false, false, false}, {false, false, false}};
    private bool is_bingoed = false;

    public bool IsBingo()
    {
        return is_bingoed;
    }

    void Start()
    {
        questionUI.SetActive(false);
        resultUI.SetActive(false);
        questionText = questionUI.transform.GetChild(1).GetComponent<Text>();
        resultText = resultUI.transform.GetChild(1).GetComponent<Text>();
        bingoText = resultUI.transform.GetChild(2).GetComponent<Text>();
        boss_animator.SetBool("is_bingo", false);
    }

    public void loadQuestion(int no)
    {
        if (questionUI.activeSelf == false && questions[no].GetComponent<Question>().GetAnswered() == false)
        {
            // load UI content
            window_pop.Play();
            curQuesNo = no;
            resultUI.SetActive(false);
            questionUI.SetActive(true);
            questionText.text = questions[no].GetComponent<Question>().question;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i < questions[no].GetComponent<Question>().options.Count)
                {
                    buttons[i].SetActive(true);
                    buttons[i].GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = questions[no].GetComponent<Question>().options[i].GetContent();
                }
                else
                {
                    buttons[i].SetActive(false);
                }
            }
            Debug.Log("Current question: " + curQuesNo);
        }
        else
        {
            Debug.Log("Question loaded. Please answer the question: " + curQuesNo);
        }
    }

    public void checkAnswer(int no)
    {
        questionUI.SetActive(false);
        resultUI.SetActive(true);
        questions[curQuesNo].GetComponent<Question>().SetAnswered(true);
        Debug.Log("Selected option: " + questions[curQuesNo].GetComponent<Question>().options[no].GetContent());
        if (questions[curQuesNo].GetComponent<Question>().options[no].IsAnswer())
        {
            Debug.Log("You are correct!!");
            resultText.text = "Correct!";
            correct_sound.Play();
            questions[curQuesNo].GetComponent<Question>().SetCorrect(true);
            int i = curQuesNo / 3;
            int j = curQuesNo % 3;
            jiugongge[i, j] = true;
            changeTexture(curQuesNo, new Color(0.27f, 0.7f, 0.43f));
            checkLine();
        }
        else
        {
            Debug.Log("You are Wrang!!");
            resultText.text = "Incorrect!";
            incorrect_sound.Play();
            questions[curQuesNo].GetComponent<Question>().SetCorrect(false);
            changeTexture(curQuesNo, new Color(0.78f, 0.33f, 0.33f));//Color.red
        }       
    }

    public void closeUI(GameObject UI)
    {
        window_close.Play();
        UI.SetActive(false);
    }

    private void changeTexture(int no, Color color)
    {
        ColorBlock btn_colors = titles[no].colors;
        btn_colors.selectedColor = color;
        btn_colors.normalColor = color;
        titles[no].colors = btn_colors;
        Text titileText = titles[no].transform.GetChild(0).GetComponent<Text>();
        titileText.color = Color.white;
    }

    private void checkLine()
    {
        if (!is_bingoed)
        {
            bool is_line = true;

            for (int i = 0; i < 3; i++)
            {
                is_line = true;
                for (int j = 0; j < 3; j++)
                {
                    // check horizontal line
                    if (jiugongge[i, j] == false)
                    {
                        is_line = false;
                        break;
                    }
                }
                if (is_line)
                    break;
            }
            if (is_line)
            {
                Bingo();
                return;
            }

            // check vertical line
            for (int i = 0; i < 3; i++)
            {
                is_line = true;
                for (int j = 0; j < 3; j++)
                {
                    // check horizontal line
                    if (jiugongge[j, i] == false)
                    {
                        is_line = false;
                        break;
                    }

                }
                if (is_line)
                    break;
            }
            if (is_line)
            {
                Bingo();
                return;
            }
            // check diagonal line
            if (jiugongge[0, 0] && jiugongge[1, 1] && jiugongge[2, 2])
            {
                Bingo();
                return;
            }

            if (jiugongge[0, 2] && jiugongge[1, 1] && jiugongge[2, 0])
            {
                Bingo();
                return;
            }
        }
        else
        {
            bingoText.text = "Already bingo!";
        }     
    }

    private void Bingo()
    {
        Debug.Log("Bingo!");
        bingoText.text = "Bingo!";
        is_bingoed = true;
        bingo_sound.Play();
        boss_animator.SetBool("is_bingo", true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Option
{
    [SerializeField]
    string selection_content;
    [SerializeField]
    bool is_answer;

    public string GetContent()
    {
        return selection_content;
    }

    public bool IsAnswer()
    {
        return is_answer;
    }
}

public class Question: MonoBehaviour
{
    public int no;
    public string title;
    public string question;
    public List<Option> options = new List<Option>();
    public QuestionController myController;
    private bool is_correct = false;
    private bool is_answered = false;

    public bool GetCorrect() { return is_correct; }
    public void SetCorrect(bool flag) { is_correct = flag; }
    public bool GetAnswered() { return is_answered; }
    public void SetAnswered(bool flag) { is_answered = flag; }
    /*private void OnTriggerEnter(Collider other)
    {
        if (!is_answered)
            myController.loadQuestion(no);
        else
            Debug.Log("This question has been answered.");
    }*/
}

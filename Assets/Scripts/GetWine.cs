using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWine : MonoBehaviour
{
    public Animator boss_animator;
    public QuestionController myContorller;
    
    void Start()
    {
        boss_animator.SetBool("is_taken", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key" && myContorller.IsBingo())
        {
            gameObject.SetActive(false);
            Debug.Log("You get the wine!");
            boss_animator.SetBool("is_taken", true);
            boss_animator.SetBool("is_bingo", false);
        }
    }
}

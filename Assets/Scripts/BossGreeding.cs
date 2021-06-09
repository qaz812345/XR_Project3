using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGreeding : MonoBehaviour
{
    public QuestionController myController;
    public AudioSource greeding_sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !myController.IsBingo())
        {
            greeding_sound.Play();
        }
    }
}

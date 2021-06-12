using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundActive : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource soundos;
    public AudioSource lightos;
    public GameObject letter;
    public AudioSource startsounds;
    public int isorder = 0;
    private bool isagain = false;
  //  public GameObject os;
   //c public GameObject os;
    // Start is called before the first frame update
    void Start()
    {
        startsounds.PlayDelayed(1.0f);
        //letteros = this.GetComponent<>();
}

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "os"&& isagain == false)
        {
            if(isorder ==0)
            {
                sound.Play();
                isorder = 1;
            }
            else if(isorder ==1)
            sound.Play();
            soundos.Play();
            lightos.PlayDelayed(10.0f);
            isagain = true;
        }
    }
}

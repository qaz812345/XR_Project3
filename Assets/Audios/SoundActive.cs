using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundActive : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource soundos;
    public AudioSource lightos;
  //  public GameObject os;
   //c public GameObject os;
    // Start is called before the first frame update
    void Start()
    {
        //os = this.transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "os")
        {
            sound.Play();
            soundos.Play();
            lightos.PlayDelayed(10.0f);
        }
    }
}

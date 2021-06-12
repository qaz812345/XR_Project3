using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public GameObject letter;
    public GameObject ipad;
    public GameObject Flower;
    Collider lettercol, ipadcol, flowercol;
    AudioSource letterhint;
    public AudioSource lettersound;
    public AudioSource clockhint, frameos,clockos;
    public GameObject flowernum;
    public GameObject EXIT;

    //public AudioClip sounds;

    private int isorder = 0;
    private bool isagain = false;
    // Start is called before the first frame update
    void Start()
    {
       // letter.AddComponent<AudioSource>() ;
        //ettercol = GetComponent<Collider>();
        //ettercol = GetComponent<Collider>();

        letterhint = letter.GetComponent<AudioSource>();
        //clockhint = ipad.AddComponent<AudioSource>() as AudioSource;
        //flowerhint = Flower.AddComponent<AudioSource>() as AudioSource;
        flowernum.SetActive(false);
        EXIT.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isagain == false)
        {
            if(other.gameObject.tag == "letter" && isorder == 0)
            {
                letterhint.Play();
                isorder = 1;
            }
            else if(other.gameObject.tag == "flower" && isorder==1)
            {
                flowernum.SetActive(true);
                isorder = 2;
            }
            else if(other.gameObject.tag == "os" && isorder==2)
            {
                clockhint.Play();
                clockos.PlayDelayed(0.5f);
                frameos.PlayDelayed(9.0f);
                EXIT.SetActive(true);
                isagain = true;
            }
            else
                isagain = false;

        }
    }
}

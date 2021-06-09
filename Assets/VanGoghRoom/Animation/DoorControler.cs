using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorControler : MonoBehaviour
{
    Animator _dooranim;
    //public Animator playeranim;
    //public GameObject videoPlayer;
   // public int timestop;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        _dooranim.SetBool("isopen", false);
        //playeranim.SetBool("iplayer", false);
        if (col.gameObject.tag == "key")
        {
            _dooranim.SetBool("isopen", true);
            //playeranim.SetBool("isplay", true);
            //videoPlayer.SetActive(true);
           // Destroy(videoPlayer, timestop);
            LoadNextScene();
        }
       
            
        
    }
    void Start()
    {
        
        _dooranim = this.transform.parent.GetComponent<Animator>();
        
      // playeranim.SetBool("isplay",false);
        //videoPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /*IEnumerator LoadtoScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }*/
}

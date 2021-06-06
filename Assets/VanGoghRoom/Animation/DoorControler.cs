using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorControler : MonoBehaviour
{
    Animator _dooranim;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        _dooranim.SetBool("isopen", false);
        if(col.gameObject.tag == "key")
        {
            _dooranim.SetBool("isopen", true);
            LoadNextScene();
        }
       
            
        
    }
    void Start()
    {
        
        _dooranim = this.transform.parent.GetComponent<Animator>();
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

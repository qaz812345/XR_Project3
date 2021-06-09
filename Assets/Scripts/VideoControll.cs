using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VideoControll : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timestop;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(videoPlayer, timestop);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

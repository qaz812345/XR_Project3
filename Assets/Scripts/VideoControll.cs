using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VideoControll : MonoBehaviour
{
    //public List<GameObject> videoPlayer;
    public GameObject video;
   // public GameObject UI;
    public float timeRemaining;
    private bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(video, timeRemaining);
        timerIsRunning = true;
       // UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {

                timeRemaining = 0.0f;
                timerIsRunning = false;
                // UI.SetActive(true);
                LoadNextScene();


            }
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}

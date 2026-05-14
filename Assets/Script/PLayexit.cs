using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PLayexit : MonoBehaviour
{
    public Button playButton;
    public Button TutorialButton;
    public Button StopButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(playOnClick);
        StopButton.onClick.AddListener(StopOnClick);
        TutorialButton.onClick.AddListener(TutorialOnClick);
    }

    void StopOnClick()
    {
        Application.Quit();
    }
    void TutorialOnClick()
    {
        SceneManager.LoadScene(1);
    }

    void playOnClick()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentIndex + 2);
        }
    }
}

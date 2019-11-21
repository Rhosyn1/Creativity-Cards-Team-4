using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonsPressed : MonoBehaviour
{

    public GameObject journalImage;
    public GameObject journalButton;
    public GameObject backButton;
    //Loading main level if play button is pressed
    public void PlayButtonPressed()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("Main Level"); //loading second scene in build
    }

    //quitting game if quit button is pressed
    public void QuitButtonPressed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void JournalButtonPressed()
    {
        //enabling the journal image and the back button
        journalImage.SetActive(true);
        journalButton.SetActive(false);
        backButton.SetActive(true);
    }

    public void BackButtonPressed()
    {
        //disabling the journal image and enabling the journal button
        journalImage.SetActive(false);
        backButton.SetActive(false);
        journalButton.SetActive(true);
    }
    
}

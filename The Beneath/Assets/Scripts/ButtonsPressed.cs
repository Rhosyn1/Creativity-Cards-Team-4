using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsPressed : MonoBehaviour
{
    //Loading main level if play button is pressed
    public void PlayButtonPressed()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1); //loading second scene in build
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
    
}

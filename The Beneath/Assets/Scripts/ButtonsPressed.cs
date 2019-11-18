using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
    public void PlayButtonPressed()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}

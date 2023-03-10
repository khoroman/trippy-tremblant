using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   

    //Play game function
    public void PlayGame()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


    //Quit game function
    public void QuitGame()
    {
        Application.Quit();
    }
}
